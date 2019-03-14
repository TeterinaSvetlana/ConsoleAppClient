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
            this.UserName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SingUp
            // 
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
            // 
            // UserName
            // 
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.UserName.Location = new System.Drawing.Point(138, 78);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(132, 20);
            this.UserName.TabIndex = 10;
            this.UserName.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Location = new System.Drawing.Point(138, 153);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Confirm password";
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 298);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.SingUp);
            this.Name = "SignUpForm";
            this.Text = "SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SingUp;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox textBox1;
    }
}