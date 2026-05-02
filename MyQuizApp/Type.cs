using System;
using System.Windows.Forms;

namespace MyQuizApp
{
    public partial class Type : Form
    {
        public Type()
        {
            InitializeComponent();
        }

        private void OpenQuiz(string fileName, string title)
        {
            Form1 quiz = new Form1(fileName, title);
            quiz.Show();
            this.Hide();
        }

        private void btnOOP_Click(object sender, EventArgs e)
        {
            OpenQuiz("MyProject.txt", "Object Oriented Programming");
        }

        private void btnMath_Click(object sender, EventArgs e)
        {
            OpenQuiz("Mathematics.txt", "Mathematics II");
        }

        private void btnElectric_Click(object sender, EventArgs e)
        {
            OpenQuiz("Electric.txt", "Electric & Electronic Circuits");
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            OpenQuiz("Statistics.txt", "Statistics");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnElectric_Click(sender, e);
        }
    }
}
