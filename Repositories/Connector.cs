using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Drawing;
using System.Collections;
using System.Collections.Generic;
using TestTracker.Models;
using System.Security.Policy;
using System.Diagnostics;

namespace TestTracker
{
    public class Connector
    {
        private SQLiteConnection _connection;
        public Connector()
        {
            var project_folder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            var pathToSQLiteDatabase = $@"URI=file:{project_folder}\Database\cases.sqlite";
            _connection = new SQLiteConnection(pathToSQLiteDatabase);
            _connection.Open();
        }

        public TestCase GetTestCase(int testcase_short_id)
        {
            string statement = $"select * from view_testcases where short_id={testcase_short_id}";
            var cmd = new SQLiteCommand(statement, _connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            reader.Read();
            TestCase testcase;
            testcase.ShortId = reader.GetInt32(0);
            testcase.Title = reader.GetString(1);
            testcase.Idea = reader.GetString(2);
            testcase.ExpectedResult = reader.GetString(3);
            testcase.QtyOfSteps = reader.GetInt32(4);
            return testcase;
        }

        public List<TestCase> GetAllTestCases()
        {
            List<TestCase> cases = new List<TestCase>();

            string statement = $"select * from view_testcases";
            var cmd = new SQLiteCommand(statement, _connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TestCase testcase;
                testcase.ShortId = reader.GetInt32(0);
                testcase.Title = reader.GetString(1);
                testcase.Idea = reader.GetString(2);
                testcase.ExpectedResult = reader.GetString(3);
                testcase.QtyOfSteps = reader.GetInt32(4);
                cases.Add(testcase);
            }
            return cases;
        }

        public List<TestSuite> GetAllTestSuites()
        {
            List<TestSuite> suites = new List<TestSuite>();

            string statement = $"select * from view_testsuites";
            var cmd = new SQLiteCommand(statement, _connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TestSuite suite;
                suite.ShortId = reader.GetInt32(0);
                suite.Title = reader.GetString(1);
                suite.QtyOfTestCases = reader.GetInt32(2);
                suites.Add(suite);
            }
            return suites;
        }

        public List<TestCase> GetTestCasesInTestSuite(int testsuite_short_id)
        {
            List<int> cases_ids = new List<int>();

            string statement = $"select * from testsuite_has_testcases where testsuite_short_id={testsuite_short_id} order by step asc";
            var cmd = new SQLiteCommand(statement, _connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int case_id = reader.GetInt32(3);
                cases_ids.Add(case_id);
            }

            List<TestCase> testcases = new List<TestCase>();
            foreach (int id in cases_ids)
            {
                TestCase testcase = GetTestCase(id);
                testcases.Add(testcase);
            }
            
            return testcases;
        }

        public TestSteps GetStepsForTestCase(int testcase_short_id)
        {
            string statement = $"select step, action from testcase_has_steps where testcase_short_id={testcase_short_id} order by step asc";
            var cmd = new SQLiteCommand(statement, _connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            TestSteps steps = new TestSteps();
            while (reader.Read())
            {
                int step = reader.GetInt32(0);
                string action = reader.GetString(1);
                steps.Add(step, action);
            }
            return steps;
        }

        public bool ExistsSavedResult(string run_id, int testcase_short_id)
        {
            string statement = $"select * from progress where run_id=\"{run_id}\" and testcase_short_id={testcase_short_id}";
            var cmd = new SQLiteCommand(statement, _connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            bool row_exists = reader.HasRows;
            return row_exists;
        }

        public void InsertRunResult(string user_login, string run_id, int testcase_short_id, string timestamp_started, string timestamp_finished, string passed)
        {
            string statement = ExistsSavedResult(run_id, testcase_short_id) ? 
                $"update progress set passed='{passed}' where user_login='{user_login}' and run_id='{run_id}' and testcase_short_id={testcase_short_id}" : 
                $"insert into progress (user_login, run_id, testcase_short_id, timestamp_started, timestamp_finished, passed) values ('{user_login}', '{run_id}', {testcase_short_id}, '{timestamp_started}', '{timestamp_finished}', '{passed}')";
            var cmd = new SQLiteCommand(statement, _connection);
            cmd.ExecuteNonQuery();
        }

        public Dictionary<TestCase, string> GetResultsOfTestCases(string user_login, string run_id)
        {
            string statement = $"select testcase_short_id, passed from progress where user_login='{user_login}' and run_id='{run_id}'";
            var cmd = new SQLiteCommand(statement, _connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            Dictionary<TestCase, string> result = new Dictionary<TestCase, string>();
            while (reader.Read())
            {
                int testcase_short_id = reader.GetInt32(0);
                string passed = reader.GetString(1);
                TestCase tcase = GetTestCase(testcase_short_id);
                result.Add(tcase, passed);
            }
            return result;
        }

        public Dictionary<TestCase, string> GetResultsOfTestCases(string user_login)
        {
            return null;
        }

        public Dictionary<string, int> GetPairOfLoginAndExpectedResult(string passed)
        {
            string statement = $"select user_login, count(*) from progress where passed='{passed}' group by user_login";
            var cmd = new SQLiteCommand(statement, _connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            Dictionary<string, int> result = new Dictionary<string, int>();
            while (reader.Read())
            {
                string user_login = reader.GetString(0);
                int count_passed = reader.GetInt32(1);
                result[user_login] = count_passed;
            }
            return result;
        }

        public string GetResultIfExists(string user_login, string run_id, int testcase_short_id)
        {
            string statement = $"select passed from progress where user_login='{user_login}' and run_id='{run_id}' and testcase_short_id={testcase_short_id}";
            var cmd = new SQLiteCommand(statement, _connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                return reader.GetString(0);
            }
            return null;
        }

        public void ReplaceTestSteps(TestCase tcase, TestSteps newSteps)
        {
            // delete old steps
            string statement = $"delete from testcase_has_steps where testcase_short_id={tcase.ShortId}";
            var cmd = new SQLiteCommand(statement, _connection);
            cmd.ExecuteNonQuery();
            // set new steps
            for (int i=1; i<=newSteps.Count; i++)
            {
                statement = $"insert into testcase_has_steps (testcase_short_id, step, action) values ({tcase.ShortId}, {i}, '{newSteps[i]}')";
                cmd = new SQLiteCommand(statement, _connection);
                cmd.ExecuteNonQuery();
            }
        }

        public List<(string, int)> GetQtyOfCasesFinished()
        {
            string statement = $"select user_login, run_id, count(testcase_short_id) from progress group by user_login, run_id";
            List<(string, int)> result = new List<(string, int)>();
            var cmd = new SQLiteCommand(statement, _connection);
            SQLiteDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string user_login = reader.GetString(0);
                int finished = reader.GetInt32(2);
                (string, int) pair = (user_login, finished);
                result.Add(pair);
            }
            return result;
        }

    }
}
