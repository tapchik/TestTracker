using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestTracker.Models;

namespace TestTracker.Forms
{
    public partial class EditStepsForm : Form
    {
        public TestSteps newSteps;
        public EditStepsForm(TestCase testcase, TestSteps steps)
        {
            InitializeComponent();
            label1.Text = testcase.Representation;
            richTextBox1.Text = steps.RepresentAsText;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            newSteps = ReadStepsFromTextBox();   
            DialogResult = DialogResult.OK;
            Close();
        }

        private TestSteps ReadStepsFromTextBox()
        {
            newSteps = new TestSteps();
            int count = 1;
            using (var reader = new StringReader(richTextBox1.Text))
            {
                for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
                {
                    newSteps.Add(count, line);
                    count += 1;
                }
            }
            return newSteps;
        }
    }
}
