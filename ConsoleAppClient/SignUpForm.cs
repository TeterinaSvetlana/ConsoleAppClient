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
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SingIn_Click(object sender, EventArgs e)
        {
            if (Password.Text == confirmPassword.Text)
            {
                User user = new User { Username = UserNameSignUp.Text, Password = Password.Text };
                Program.CreateAsync(user);

                this.Close();
            }
            else MessageBox.Show("Passwords aren't equal");
        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {
            if ((UserNameSignUp.Text != "") && (Password.Text != "")&&(confirmPassword.Text!=""))
                SingUp.Enabled = true;

            if ((UserNameSignUp.Text == "") || (Password.Text == "") || (confirmPassword.Text == ""))
                SingUp.Enabled = false;
        }

        private void UserName_Click(object sender, EventArgs e)
        {
            UserNameSignUp.Text = "";
            UserNameSignUp.Font = new Font("Arial", (float)8.25, FontStyle.Regular);
            UserNameSignUp.ForeColor = Color.Black;
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            UserNameSignUp.Enabled = true;
            Password.Enabled = true;
            confirmPassword.Enabled = true;
        }

        private void Password_Click(object sender, EventArgs e)
        {
            Password.Text = "";
            Password.Font = new Font("Arial", (float)8.25, FontStyle.Regular);
            Password.ForeColor = Color.Black;
        }

        private void confirmPassword_Click(object sender, EventArgs e)
        {
            confirmPassword.Text = "";
            confirmPassword.Font = new Font("Arial", (float)8.25, FontStyle.Regular);
            confirmPassword.ForeColor = Color.Black;
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
            if ((UserNameSignUp.Text != "") && (Password.Text != "") && (confirmPassword.Text != ""))
                SingUp.Enabled = true;

            if ((UserNameSignUp.Text == "") || (Password.Text == "") || (confirmPassword.Text == ""))
                SingUp.Enabled = false;
        }

        private void confirmPassword_TextChanged(object sender, EventArgs e)
        {
            if ((UserNameSignUp.Text != "") && (Password.Text != "") && (confirmPassword.Text != ""))
                SingUp.Enabled = true;

            if ((UserNameSignUp.Text == "") || (Password.Text == "") || (confirmPassword.Text == ""))
                SingUp.Enabled = false;
        }
    }
}
