using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTracker.Models;

namespace TestTracker.Forms
{
    public partial class ReportForm : Form
    {
        private Connector connector;
        private string user_login;
        private string run_id;

        public ReportForm(Connector connector, string user_login, string run_id)
        {
            this.connector = connector;
            this.user_login = user_login;
            this.run_id = run_id;
            InitializeComponent();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    FormReportOne();
                    break;
                case 1:
                    FormReportTwo();
                    break;
                case 2:
                    FormReportThree();
                    break;
                case 3:
                    FormReportFour();
                    break;
                case 4:
                    FormReportFive();
                    break;
            }
        }

        private void FormReportOne()
        {
            string report = "Report:\tTestcases passed in current run\n";
            report += $"Login:\t{this.user_login}\n";
            report += $"Run id:\t{this.run_id}\n";
            report += $"\n";

            Dictionary<TestCase, string> passed_cases = connector.GetResultsOfTestCases(user_login, run_id);
            foreach (TestCase tcase in passed_cases.Keys)
            {
                report += $"{passed_cases[tcase]}\t{tcase.Representation}\n";
            }
            report += $"\nTotal testcases passed: {passed_cases.Count} testcases";
            richTextBoxReport.Text = report;
        }

        private void FormReportTwo()
        {
            Dictionary<string, int> passed = connector.GetPairOfLoginAndExpectedResult("Passed");
            Dictionary<string, int> blocked = connector.GetPairOfLoginAndExpectedResult("Blocked");
            Dictionary<string, int> total = new Dictionary<string, int>();
            foreach (var pair in passed)
            {
                total[pair.Key] = pair.Value;
                if (!blocked.ContainsKey(pair.Key))
                    blocked[pair.Key] = 0;
            }
            foreach (var pair in blocked)
            {
                if (!passed.ContainsKey(pair.Key))
                    passed[pair.Key] = 0;
                if (total.ContainsKey(pair.Key))
                {
                    total[pair.Key] += pair.Value;
                } else
                {
                    total[pair.Key] = 0;
                }
            }

            string report = "Report:\tAnalyze percentage of passed testcases\n";
            report += $"Login:\t{this.user_login}\n";
            report += $"Run id:\t{this.run_id}\n";
            report += $"\n";

            report += $"Login: passed + blocked = total (passed / total * 100%)\n";
            foreach (var pair in total)
            {
                string login = pair.Key;
                int one = passed[login];
                int two = blocked[login];
                double percentage = (double)one / (one + two);
                report += $"- {login}: {one} + {two} = {one+two} ({String.Format("{0:P2}.", percentage)})\n";
            }
            richTextBoxReport.Text = report;
        }

        private void FormReportThree()
        {
            List<(string, int)> finished = connector.GetQtyOfCasesFinished();
            Dictionary<string, int> total = new Dictionary<string, int>();
            Dictionary<string, int> qty_of_runs = new Dictionary<string, int>();
            foreach (var pair in finished)
            {
                if (total.ContainsKey(pair.Item1))
                    total[pair.Item1] += pair.Item2;
                else
                    total[pair.Item1] = pair.Item2;
                if (qty_of_runs.ContainsKey(pair.Item1))
                    qty_of_runs[pair.Item1] += 1;
                else
                    qty_of_runs[pair.Item1] = 1;
            }
            Dictionary<string, float> average = new Dictionary<string, float>();
            foreach (var item in total)
            {
                average[item.Key] = (float)total[item.Key] / qty_of_runs[item.Key];
            }


            string report = "Report:\tAverage testcases finished by user\n";
            report += $"Login:\t{this.user_login}\n";
            report += $"Run id:\t{this.run_id}\n";
            report += $"\n";

            report += $"Login: total / qty of runs = average\n";
            foreach (var pair in total)
            {
                string login = pair.Key;
                report += $"- {login}: {total[login]} / {qty_of_runs[login]} = {average[login]}\n";
            }
            richTextBoxReport.Text = report;
        }

        private void FormReportFour()
        {
            List<TestCase> testcases = connector.GetAllTestCases();

            string report = "Report:\tTest steps for all testcases\n";
            report += $"Login:\t{this.user_login}\n";
            report += $"Run id:\t{this.run_id}\n";
            report += $"\n";
            foreach (TestCase tcase in testcases)
            {
                report += $"{tcase.Representation}\n";
                TestSteps steps = connector.GetStepsForTestCase(tcase.ShortId);
                for (int i = 1; i<=steps.Count; i++)
                {
                    report += $"{i}. {steps[i]}\n";
                }
                report += "\n";
            }
            richTextBoxReport.Text = report;
        }

        private void FormReportFive()
        {
            List<TestSuite> suites = connector.GetAllTestSuites();

            string report = "Report:\tTestcases in test suites\n";
            report += $"Login:\t{this.user_login}\n";
            report += $"Run id:\t{this.run_id}\n";
            report += $"\n";
            foreach (TestSuite suite in suites)
            {
                report += $"{suite.Representation}\n";
                List<TestCase> cases = connector.GetTestCasesInTestSuite(suite.ShortId);
                int count = 1;
                foreach (TestCase tcase in cases)
                {
                    report += $"{count}. {tcase.Representation}\n";
                    count++;
                }
                report += "\n";
            }
            richTextBoxReport.Text = report;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Tab separated values|*.tsv";
            saveFileDialog1.Title = "Save report";
            saveFileDialog1.ShowDialog();
            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                using (FileStream fs = (FileStream)saveFileDialog1.OpenFile())
                {
                    string reportText = richTextBoxReport.Text;
                    byte[] info = new UTF8Encoding(true).GetBytes(reportText);
                    fs.Write(info, 0, info.Length);
                }
                // notify that report save successfuly
                string message = "Your report is successfuly saved to a file!";
                string title = "Report saved";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
        }
    }
}
