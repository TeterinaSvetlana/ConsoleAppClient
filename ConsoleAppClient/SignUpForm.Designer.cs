namespace ConsoleAppClient
{
    partial class SignUpForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SingUp = new System.Windows.Forms.Button();
            this.Password = new System.Windows.Forms.TextBox();
            this.UserNameSignUp = new System.Windows.Forms.TextBox();
            this.confirmPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SingUp
            // 
            this.SingUp.Enabled = false;
            this.SingUp.Location = new System.Drawing.Point(162, 191);
            this.SingUp.Name = "SingUp";
            this.SingUp.Size = new System.Drawing.Size(84, 24);
            this.SingUp.TabIndex = 9;
            this.SingUp.Text = "Sign up";
            this.SingUp.UseVisualStyleBackColor = true;
            this.SingUp.Click += new System.EventHandler(this.SingIn_Click);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Password.Location = new System.Drawing.Point(138, 114);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(132, 20);
            this.Password.TabIndex = 11;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // UserNameSignUp
            // 
            this.UserNameSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameSignUp.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.UserNameSignUp.Location = new System.Drawing.Point(138, 78);
            this.UserNameSignUp.Name = "UserNameSignUp";
            this.UserNameSignUp.Size = new System.Drawing.Size(132, 20);
            this.UserNameSignUp.TabIndex = 10;
            this.UserNameSignUp.Text = "Username";
            this.UserNameSignUp.Click += new System.EventHandler(this.UserName_Click);
            this.UserNameSignUp.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // confirmPassword
            // 
            this.confirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.confirmPassword.Location = new System.Drawing.Point(138, 153);
            this.confirmPassword.Name = "confirmPassword";
            this.confirmPassword.Size = new System.Drawing.Size(132, 20);
            this.confirmPassword.TabIndex = 12;
            this.confirmPassword.Text = "Confirm password";
            this.confirmPassword.Click += new System.EventHandler(this.confirmPassword_Click);
            this.confirmPassword.TextChanged += new System.EventHandler(this.confirmPassword_TextChanged);
            // 
            // SignUpForm
            // 
            this.AcceptButton = this.SingUp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 298);
            this.Controls.Add(this.confirmPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserNameSignUp);
            this.Controls.Add(this.SingUp);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.Load += new System.EventHandler(this.SignUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SingUp;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox UserNameSignUp;
        private System.Windows.Forms.TextBox confirmPassword;
    }
}