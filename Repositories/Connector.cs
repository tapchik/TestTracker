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

namespace TestTracker
{
    internal class Connector
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
    }
}
