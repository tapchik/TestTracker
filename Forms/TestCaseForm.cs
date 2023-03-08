using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTracker.Models;

namespace TestTracker.Forms
{
    public partial class TestCaseForm : Form
    {
        public TestCaseForm(TestCase testcase, TestSteps teststeps)
        {
            InitializeComponent();
            this.labelTitle.Text = testcase.Title;
            this.labelExpectedResult.Text = testcase.ExpectedResult;

            var orderedSteps = teststeps.OrderBy(x => x.Key);
            foreach (var step in orderedSteps)
            {
                this.checkedListOfSteps.Items.Add(step.Value);
            }
        }
    }
}
