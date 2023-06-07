namespace testingnanaman
{
    partial class FormSignup
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
            this.metroButtonCreateAccount = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxCreateUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxCreatePassword = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButtonCreateAccount
            // 
            this.metroButtonCreateAccount.Location = new System.Drawing.Point(117, 266);
            this.metroButtonCreateAccount.Name = "metroButtonCreateAccount";
            this.metroButtonCreateAccount.Size = new System.Drawing.Size(99, 36);
            this.metroButtonCreateAccount.TabIndex = 0;
            this.metroButtonCreateAccount.Text = "Create Account";
            this.metroButtonCreateAccount.Click += new System.EventHandler(this.metroButtonCreateAccount_Click);
            // 
            // metroTextBoxCreateUsername
            // 
            this.metroTextBoxCreateUsername.Location = new System.Drawing.Point(83, 98);
            this.metroTextBoxCreateUsername.Name = "metroTextBoxCreateUsername";
            this.metroTextBoxCreateUsername.Size = new System.Drawing.Size(169, 23);
            this.metroTextBoxCreateUsername.TabIndex = 1;
            // 
            // metroTextBoxCreatePassword
            // 
            this.metroTextBoxCreatePassword.Location = new System.Drawing.Point(83, 159);
            this.metroTextBoxCreatePassword.Name = "metroTextBoxCreatePassword";
            this.metroTextBoxCreatePassword.PasswordChar = '●';
            this.metroTextBoxCreatePassword.Size = new System.Drawing.Size(169, 23);
            this.metroTextBoxCreatePassword.TabIndex = 2;
            this.metroTextBoxCreatePassword.UseSystemPasswordChar = true;
            // 
            // metroTextBoxConfirmPassword
            // 
            this.metroTextBoxConfirmPassword.Location = new System.Drawing.Point(83, 222);
            this.metroTextBoxConfirmPassword.Name = "metroTextBoxConfirmPassword";
            this.metroTextBoxConfirmPassword.PasswordChar = '●';
            this.metroTextBoxConfirmPassword.Size = new System.Drawing.Size(169, 23);
            this.metroTextBoxConfirmPassword.TabIndex = 3;
            this.metroTextBoxConfirmPassword.UseSystemPasswordChar = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(83, 76);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(68, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Username";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(83, 137);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(63, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Password";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(83, 200);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(115, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Confirm Password";
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(13, 346);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(99, 36);
            this.metroButton2.TabIndex = 7;
            this.metroButton2.Text = "Back";
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // FormSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 393);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxConfirmPassword);
            this.Controls.Add(this.metroTextBoxCreatePassword);
            this.Controls.Add(this.metroTextBoxCreateUsername);
            this.Controls.Add(this.metroButtonCreateAccount);
            this.Name = "FormSignup";
            this.Text = "Create Account";
            this.Load += new System.EventHandler(this.FormSignup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButtonCreateAccount;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCreateUsername;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCreatePassword;
        private MetroFramework.Controls.MetroTextBox metroTextBoxConfirmPassword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton metroButton2;
    }
}