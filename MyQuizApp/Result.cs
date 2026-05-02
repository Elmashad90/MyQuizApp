using System;
using System.Windows.Forms;

namespace MyQuizApp
{
    public partial class Result : Form
    {
        private string questionsFileName = "MyProject.txt";
        private string quizTitle = "Object Oriented Programming";

        public Result()
        {
            InitializeComponent();
        }

        public Result(int score, int total) : this(score, total, "MyProject.txt", "Object Oriented Programming")
        {
        }

        public Result(int score, int total, string questionsFileName, string quizTitle)
        {
            InitializeComponent();
            this.questionsFileName = questionsFileName;
            this.quizTitle = quizTitle;
            lblScore.Text = "Quiz Finished!\n" + quizTitle + "\nYour Score: " + score + " / " + total;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnRety_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1(questionsFileName, quizTitle);
            frm.Show();
            this.Close();
            //Ahmed
            //hossam
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
