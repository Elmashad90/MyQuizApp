using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyQuizApp
{
    public partial class FormSignUp : Form
    {
        private readonly string usersFilePath = Path.Combine(Application.StartupPath, "users.txt");

        public FormSignUp()
        {
            InitializeComponent();
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtName2.Text;
            string password = txtPassword2.Text;
            string confirmPassword = txtConfirm2.Text;

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill all fields.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (userName.Contains(",") || password.Contains(","))
            {
                MessageBox.Show("Username and password cannot contain comma (,).", "Invalid Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Password and Confirm Password do not match.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(usersFilePath))
                File.WriteAllText(usersFilePath, "Ahmed,12123" + Environment.NewLine);
            //Ahmed 
            bool userExists = false;
            //Mohamed

            string[] lines = File.ReadAllLines(usersFilePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] data = line.Split(',');

                if (data.Length >= 1)
                {
                    string existingUserName = data[0];
                    string newUserName = userName;

                    if (existingUserName == newUserName)
                    {
                        userExists = true;
                    }
                }
            }

            if (userExists)
            {
                MessageBox.Show("Username already exists.", "Duplicate User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            File.AppendAllText(usersFilePath, userName + "," + password + Environment.NewLine);
            MessageBox.Show("Account created successfully. You can login now.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtName2_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtConfirm2_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblName_Click(object sender, EventArgs e)
        {
        }

        private void lblPassWord_Click(object sender, EventArgs e)
        {
        }

        private void lblConfirmPW_Click(object sender, EventArgs e)
        {
        }
    }
}
