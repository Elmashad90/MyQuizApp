using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyQuizApp
{
    public partial class Login : Form
    {
        private readonly string usersFilePath = Path.Combine(Application.StartupPath, "users.txt");

        public Login()
        {
            InitializeComponent();
        }

        private void EnsureDefaultUserExists()
        {
            if (!File.Exists(usersFilePath))
                File.WriteAllText(usersFilePath, "Ahmed,12123" + Environment.NewLine);
        }

        private bool IsValidUser(string userName, string password)
        {
            EnsureDefaultUserExists();

            return File.ReadAllLines(usersFilePath)
                .Where(row => !string.IsNullOrWhiteSpace(row))
                .Select(line => line.Split(','))
                .Any(data => data.Length >= 2
                             && data[0].Trim().Equals(userName, StringComparison.OrdinalIgnoreCase)
                             && data[1].Trim() == password);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            string userName = txtUser.Text.Trim();
            string password = txtPass.Text.Trim();

            if (string.IsNullOrWhiteSpace(userName) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (IsValidUser(userName, password))
            {
                Type typeForm = new Type();
                typeForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password is wrong.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormSignUp signUpForm = new FormSignUp();
            signUpForm.ShowDialog();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            EnsureDefaultUserExists();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
