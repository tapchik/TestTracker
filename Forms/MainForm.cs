using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
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

        string user_login;
        string run_id;

        public MainForm()
        {
            InitializeComponent();
            Connector = new Connector();

            using (var loginForm = new LoginForm())
            {
                var result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.user_login = loginForm.login;
                    this.run_id = loginForm.runId;
                    RefreshBasicInfo();
                }
            }
            RefreshListOfTestSuites();
        }

        private void RefreshBasicInfo()
        {
            this.textBoxLogin.Text = this.user_login;
            this.textBoxRunId.Text = this.run_id;
            this.treeViewOfTestSuites.BeginUpdate();
            foreach (TreeNode node_suite in treeViewOfTestSuites.Nodes)
            {
                foreach (TreeNode node_case in node_suite.Nodes)
                {
                    string passed = Connector.GetResultIfExists(this.user_login, this.run_id, Convert.ToInt32(node_case.Tag));
                    switch (passed)
                    {
                        case "Passed":
                            node_case.BackColor = Color.LightGreen;
                            break;
                        case "Blocked":
                            node_case.BackColor = Color.LightPink;
                            break;
                    }
                    if (node_case.Tag != null)
                    {
                        TestCase tcase = Connector.GetTestCase(Convert.ToInt32(node_case.Tag));
                        node_case.Text = tcase.Representation;
                    }

                }
            }
            this.treeViewOfTestSuites.EndUpdate();
            // if admin/root
            if (user_login == "admin" && run_id == "root")
            {
                btnBulkEdit.Enabled = true;
            } else {
                btnBulkEdit.Enabled = false;
            }
        }

        private void RefreshListOfTestSuites()
        {
            List<TestSuite> suites = Connector.GetAllTestSuites();

            this.treeViewOfTestSuites.BeginUpdate();
            this.treeViewOfTestSuites.Nodes.Clear();
            foreach (TestSuite suite in suites)
            {
                TreeNode node_suite = treeViewOfTestSuites.Nodes.Add(suite.Representation);
                List<TestCase> testcases = Connector.GetTestCasesInTestSuite(suite.ShortId);
                foreach (TestCase testcase in testcases)
                {
                    var node_case = node_suite.Nodes.Add(testcase.FullId.ToString(), testcase.Representation);
                    node_case.Tag = testcase.ShortId;
                    string passed = Connector.GetResultIfExists(this.user_login, this.run_id, testcase.ShortId);
                    switch (passed)
                    {
                        case "Passed":
                            node_case.BackColor = Color.LightGreen;
                            break;
                        case "Blocked":
                            node_case.BackColor = Color.LightPink;
                            break;
                    }
                }
            }
            this.treeViewOfTestSuites.EndUpdate();
            TreeNode ddd = treeViewOfTestSuites.SelectedNode;
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
            int testcase_short_id = this.ShortIdOfSelectedTestCase;
            try
            {
                TestCase tcase = Connector.GetTestCase(testcase_short_id);
                TestSteps tsteps = Connector.GetStepsForTestCase(testcase_short_id);
                using (var form = new TestCaseForm(tcase, tsteps))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        string passed = form.result;
                        Connector.InsertRunResult(this.user_login, this.run_id, tcase.ShortId, "2023-13-13", "2023-13-13", passed);
                    }
                    RefreshBasicInfo();
                }
            } catch (Exception ex)
            {
                return;
            }

        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            using (var loginForm = new LoginForm())
            {
                var result = loginForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    this.user_login = loginForm.login;
                    this.run_id = loginForm.runId;
                    RefreshBasicInfo();
                }
            }
            RefreshListOfTestSuites();
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            using (var loginForm = new ReportForm(this.Connector, this.user_login, this.run_id))
            {
                var result = loginForm.ShowDialog();
            }
        }

        private void btnBulkEdit_Click(object sender, EventArgs e)
        {
            int testcase_short_id = this.ShortIdOfSelectedTestCase;
            try
            {
                TestCase tcase = Connector.GetTestCase(testcase_short_id);
                TestSteps tsteps = Connector.GetStepsForTestCase(testcase_short_id);
                using (var form = new EditStepsForm(tcase, tsteps))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        TestSteps newSteps = form.newSteps;
                        Connector.ReplaceTestSteps(tcase, newSteps);
                    }
                    RefreshBasicInfo();
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}
