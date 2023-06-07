using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiteDB;
using System.Security.Cryptography;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Common;
using static testingnanaman.FormSignup;

namespace testingnanaman
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        private LiteDatabase db;
        public LoginForm()
        {
            InitializeComponent();
        }
        static internal string GetBasePath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string directoryPath = $"{GetBasePath()}\\TeacherPortal";

            try
            {
                //Checks if the directory exists
                if (Directory.Exists(directoryPath))
                {
                }
                else
                {
                    //Creates Directory
                    Directory.CreateDirectory(directoryPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error creating directory: " + ex.Message);
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form f2 = new FormSignup();
            f2.Show();
            this.Hide();
        }

        private void metroButtonLogin_Click(object sender, EventArgs e)
        {
            string username = metroTextBoxUsername.Text;
            string password = metroTextBoxPassword.Text;

            db = new LiteDatabase(DBConnection.databaseConnection_account);
            var collection = db.GetCollection<UserData>("Account");
            var loginAccountData = collection.FindOne(x => x.Username == username);

            if (loginAccountData != null)
            {
                if (password == loginAccountData.Password)
                {
                    Form f4 = new TeacherPortal();
                    f4.Show();
                    this.Hide();
                    db.Dispose();
                }
                else
                {
                    MessageBox.Show("Password is Invalid!");
                }
            }
            else
            {
                MessageBox.Show("Username not found.");
            }

            db.Dispose();
        }
    }
    
}
