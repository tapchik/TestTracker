using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTracker.Forms
{
    public partial class LoginForm : Form
    {
        public string login;
        public string runId;

        public LoginForm()
        {
            InitializeComponent();
            this.login = "";
            this.runId= "";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.login = this.textBoxLogin.Text;
            this.runId = this.textBoxRunId.Text;
            if (AllFieldsFilled() == true)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }
            
            // in case fields are not filled
            using (ErrorLoginForm errorForm = new ErrorLoginForm())
            {
                errorForm.ShowDialog();
            }
        }

        private void textBoxRunId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin_Click(sender, e);
                return;
            }
        }

        private void textBoxLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxRunId.Focus();
                return;
            }
        }

        private bool AllFieldsFilled()
        {
            if (this.login.Length > 0 && this.runId.Length > 0)
                return true;
            return false;
        }
    }
}
