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
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
