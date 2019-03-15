namespace ConsoleAppClient
{
    partial class StartForm
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
            this.UserName = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.SingIn = new System.Windows.Forms.Button();
            this.SignUp = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.UserName.Location = new System.Drawing.Point(143, 72);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(132, 20);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "Username";
            this.UserName.Click += new System.EventHandler(this.UserName_Click);
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            // 
            // Password
            // 
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Password.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Password.Location = new System.Drawing.Point(143, 108);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(132, 20);
            this.Password.TabIndex = 3;
            this.Password.Text = "Password";
            this.Password.Click += new System.EventHandler(this.Password_Click);
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // SingIn
            // 
            this.SingIn.Enabled = false;
            this.SingIn.Location = new System.Drawing.Point(162, 150);
            this.SingIn.Name = "SingIn";
            this.SingIn.Size = new System.Drawing.Size(84, 24);
            this.SingIn.TabIndex = 4;
            this.SingIn.Text = "Sign in";
            this.SingIn.UseVisualStyleBackColor = true;
            this.SingIn.Click += new System.EventHandler(this.SingIn_Click);
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.Location = new System.Drawing.Point(181, 198);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(43, 13);
            this.SignUp.TabIndex = 5;
            this.SignUp.TabStop = true;
            this.SignUp.Text = "Sign up";
            this.SignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUp_LinkClicked);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 252);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.SingIn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Name = "StartForm";
            this.Text = "StartForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button SingIn;
        private System.Windows.Forms.LinkLabel SignUp;
    }
}