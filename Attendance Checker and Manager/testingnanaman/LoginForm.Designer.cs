namespace testingnanaman
{
    partial class LoginForm
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
            this.metroTextBoxUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonLogin = new MetroFramework.Controls.MetroButton();
            this.metroButtonLoginCreateAccount = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTextBoxUsername
            // 
            this.metroTextBoxUsername.Location = new System.Drawing.Point(73, 101);
            this.metroTextBoxUsername.Name = "metroTextBoxUsername";
            this.metroTextBoxUsername.Size = new System.Drawing.Size(219, 23);
            this.metroTextBoxUsername.TabIndex = 0;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(73, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Username";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(73, 141);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Password";
            // 
            // metroTextBoxPassword
            // 
            this.metroTextBoxPassword.Location = new System.Drawing.Point(73, 163);
            this.metroTextBoxPassword.Name = "metroTextBoxPassword";
            this.metroTextBoxPassword.PasswordChar = '●';
            this.metroTextBoxPassword.Size = new System.Drawing.Size(219, 23);
            this.metroTextBoxPassword.TabIndex = 2;
            this.metroTextBoxPassword.UseSystemPasswordChar = true;
            // 
            // metroButtonLogin
            // 
            this.metroButtonLogin.Location = new System.Drawing.Point(191, 209);
            this.metroButtonLogin.Name = "metroButtonLogin";
            this.metroButtonLogin.Size = new System.Drawing.Size(101, 38);
            this.metroButtonLogin.TabIndex = 4;
            this.metroButtonLogin.Text = "Login";
            this.metroButtonLogin.Click += new System.EventHandler(this.metroButtonLogin_Click);
            // 
            // metroButtonLoginCreateAccount
            // 
            this.metroButtonLoginCreateAccount.Location = new System.Drawing.Point(73, 209);
            this.metroButtonLoginCreateAccount.Name = "metroButtonLoginCreateAccount";
            this.metroButtonLoginCreateAccount.Size = new System.Drawing.Size(101, 38);
            this.metroButtonLoginCreateAccount.TabIndex = 5;
            this.metroButtonLoginCreateAccount.Text = "Create Account";
            this.metroButtonLoginCreateAccount.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 293);
            this.Controls.Add(this.metroButtonLoginCreateAccount);
            this.Controls.Add(this.metroButtonLogin);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBoxPassword);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxUsername);
            this.Name = "LoginForm";
            this.Text = "Attendance Sheet Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxUsername;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxPassword;
        private MetroFramework.Controls.MetroButton metroButtonLogin;
        private MetroFramework.Controls.MetroButton metroButtonLoginCreateAccount;
    }
}

