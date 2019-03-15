using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleAppClient
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
        }

        private void UserName_Click(object sender, EventArgs e)
        {
            UserName.Text = "";
            UserName.Font = new Font("Arial", (float)8.25, FontStyle.Regular);
            UserName.ForeColor = Color.Black;
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Password.Text = "";
            Password.Font = new Font("Arial", (float)8.25, FontStyle.Regular);
            Password.ForeColor = Color.Black;
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            if ((UserName.Text != "") && (Password.Text != ""))
                SingIn.Enabled = true;

            if ((UserName.Text == "") || (Password.Text == ""))
                SingIn.Enabled = false;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if ((UserName.Text != "") && (Password.Text != ""))
                SingIn.Enabled = true;

            if ((UserName.Text == "") || (Password.Text == ""))
                SingIn.Enabled = false;
        }

        private void SingIn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
