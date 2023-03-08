using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTracker.Forms;
using TestTracker.Models;

namespace TestTracker
{
    public partial class MainForm : Form
    {

        private Connector Connector;
        int ShortIdOfSelectedTestCase;

        public MainForm()
        {
            InitializeComponent();
            Connector = new Connector();

            using (var loginForm = new LoginForm())
            {
                var result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.textBoxLogin.Text = loginForm.login;
                    this.textBoxRunId.Text = loginForm.runId;
                }
            }

            RefreshListOfTestSuites();
            TestRun();
        }

        public void TestRun()
        {
            List<TestCase> testCases = Connector.GetAllTestCases();
            int x = 5;
        }

        private void RefreshListOfTestSuites()
        {
            List<TestSuite> suites = Connector.GetAllTestSuites();

            this.treeViewOfTestSuites.BeginUpdate();
            this.treeViewOfTestSuites.Nodes.Clear();
            foreach (TestSuite suite in suites)
            {
                TreeNode node = treeViewOfTestSuites.Nodes.Add(suite.Representation);
                List<TestCase> testcases = Connector.GetTestCasesInTestSuite(suite.ShortId);
                foreach (TestCase testcase in testcases)
                {
                    node.Nodes.Add(testcase.FullId, testcase.Representation);
                }

            }
            //this.treeViewOfTestSuites.
            this.treeViewOfTestSuites.EndUpdate();
        }

        private void treeViewOfTestSuites_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string FullIdOfTC = e.Node.Name;
            if (FullIdOfTC.StartsWith("TC") == false) {
                ShortIdOfSelectedTestCase = -1;
                textBoxTitleOfTC.Clear();
                textBoxIdeaOfTC.Clear();
                textBoxExpectedResultOfTC.Clear();
                buttonRun.Enabled = false;
                return;
            }
            string substring = FullIdOfTC.Substring(2);
            int testcase_short_id = Int32.Parse(substring);
            TestCase testcase = Connector.GetTestCase(testcase_short_id);
            ShortIdOfSelectedTestCase = testcase.ShortId;
            textBoxTitleOfTC.Text = testcase.Representation;
            textBoxIdeaOfTC.Text = testcase.Idea;
            textBoxExpectedResultOfTC.Text = testcase.ExpectedResult;
            buttonRun.Enabled = true;
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            int testcase_short_id = ShortIdOfSelectedTestCase;
            TestCase tcase = Connector.GetTestCase(testcase_short_id);
            TestSteps tsteps = Connector.GetStepsForTestCase(testcase_short_id);
            TestCaseForm form = new TestCaseForm(tcase, tsteps);
            form.ShowDialog();
        }
    }
}
