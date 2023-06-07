using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testingnanaman
{
    public partial class FormSignup : MetroFramework.Forms.MetroForm
    {
        private LiteDatabase db;
        public FormSignup()
        {
            InitializeComponent();
        }

        private void FormSignup_Load(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form f3 = new LoginForm();
            f3.Show();
            this.Hide();
        }

        private void metroButtonCreateAccount_Click(object sender, EventArgs e)
        {
            // Get the values from the text boxes
            string username = metroTextBoxCreateUsername.Text;
            string password = metroTextBoxConfirmPassword.Text;

            //check if textbox1 to textbox3 if they contain any text
            if (metroTextBoxCreateUsername.Text == "" || metroTextBoxCreatePassword.Text == "" || metroTextBoxConfirmPassword.Text == "")
            {
                //if they are empty, show a message box
                MessageBox.Show("Please fill in all the fields.");
                return;
            }

            db = new LiteDatabase(DBConnection.databaseConnection_account);
            var collection = db.GetCollection<UserData>("Account");

            var existingAccount = collection.FindOne(x => x.Username == username);
            if (existingAccount != null)
            {
                MessageBox.Show("Username already exists.");
                db.Dispose();
                return;
            }

            // Create a new user data
            var userData = new UserData
            {
                Username = username,
                Password = password
            };

            // Insert the data item into the collection
            collection.Upsert(userData);

            MessageBox.Show("Account created!");
            db.Dispose();

            Form f1 = new LoginForm();
            f1.Show();
            this.Hide();
        }
        public class UserData
        {
            public string Username { get; set; }
            public string Password { get; set; }
        }
    }
}
