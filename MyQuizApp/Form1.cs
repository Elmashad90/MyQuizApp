using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace MyQuizApp
{
    public partial class Form1 : Form
    {
        private readonly string questionsFileName;
        private readonly string quizTitle;
        private List<Question> questions;
        private int currentIndex = 0;
        private int score = 0;
        private int timeleft = 10;
        private const int SecondsPerQuestion = 10;

        public Form1() : this("MyProject.txt", "Object Oriented Programming")
        {
        }

        public Form1(string questionsFileName, string quizTitle)
        {
            InitializeComponent();
            this.questionsFileName = questionsFileName;
            this.quizTitle = quizTitle;
            this.Text = quizTitle + " Quiz";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            questions = LoadQuestions();

            lblQuestion.Visible = false;
            btnNext.Visible = false;
            btnFinish.Visible = false;
            lblTimer.Visible = false;
            rb1.Visible = rb2.Visible = rb3.Visible = rb4.Visible = false;

            if (questions.Count == 0)
            {
                btnStart.Enabled = false;
                MessageBox.Show("No valid questions were found for " + quizTitle + ".", "Questions not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private List<Question> LoadQuestions()
        {
            List<Question> loadedQuestions = new List<Question>();
            string filePath = Path.Combine(Application.StartupPath, questionsFileName);

            if (!File.Exists(filePath))
            {
                MessageBox.Show("Questions file is missing:\n" + filePath, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return loadedQuestions;
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                try
                {
                    string[] parts = line.Split('|');

                    if (parts.Length != 4)
                        continue;

                    string text = parts[0].Trim();
                    string[] choices = parts[1].Split(',').Select(choice => choice.Trim()).ToArray();
                    int correctAnswer = int.Parse(parts[2].Trim());
                    QuestionLevel level = (QuestionLevel)Enum.Parse(typeof(QuestionLevel), parts[3].Trim(), true);

                    if (choices.Length != 4 || correctAnswer < 0 || correctAnswer > 3)
                        continue;

                    loadedQuestions.Add(new Question(text, choices, correctAnswer, level));
                }
                catch
                {
                    // Skip invalid question lines instead of stopping the whole quiz.
                }
            }

            return loadedQuestions;
        }

        private void ShowQuestions()
        {
            if (currentIndex >= questions.Count)
            {
                ShowResult();
                return;
            }

            Question q = questions[currentIndex];

            lblQuestion.Text = "Question " + (currentIndex + 1) + " of " + questions.Count + ": " + q.Text;

            rb1.Checked = false;
            rb2.Checked = false;
            rb3.Checked = false;
            rb4.Checked = false;

            rb1.Text = q.Choices[0];
            rb2.Text = q.Choices[1];
            rb3.Text = q.Choices[2];
            rb4.Text = q.Choices[3];

            timeleft = SecondsPerQuestion;
            lblTimer.ForeColor = Color.Green;
            lblTimer.Text = timeleft.ToString();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeleft--;
            lblTimer.Text = timeleft.ToString();

            if (timeleft <= 3)
                lblTimer.ForeColor = Color.Red;
            else if (timeleft <= 6)
                lblTimer.ForeColor = Color.Orange;
            else
                lblTimer.ForeColor = Color.Green;

            if (timeleft <= 0)
            {
                timer1.Stop();
                MoveToNextQuestion();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MoveToNextQuestion();
        }

        private int GetSelectedAnswer()
        {
            if (rb1.Checked) return 0;
            if (rb2.Checked) return 1;
            if (rb3.Checked) return 2;
            if (rb4.Checked) return 3;
            return -1;
        }

        private void SubmitCurrentAnswer()
        {
            if (currentIndex >= questions.Count)
                return;

            int answer = GetSelectedAnswer();

            if (questions[currentIndex].CheckAnswer(answer))
                score++;
        }

        private void MoveToNextQuestion()
        {
            SubmitCurrentAnswer();
            currentIndex++;

            if (currentIndex < questions.Count)
                ShowQuestions();
            else
                ShowResult();
        }

        private void ShowResult()
        {
            timer1.Stop();
            Result result = new Result(score, questions.Count, questionsFileName, quizTitle);
            result.Show();
            this.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (questions.Count == 0)
                return;

            btnStart.Visible = false;

            lblQuestion.Visible = true;
            btnNext.Visible = true;
            btnFinish.Visible = true;
            lblTimer.Visible = true;
            rb1.Visible = rb2.Visible = rb3.Visible = rb4.Visible = true;

            currentIndex = 0;
            score = 0;

            ShowQuestions();
        }

        private void lblTimer_Click(object sender, EventArgs e)
        {
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            SubmitCurrentAnswer();
            ShowResult();
        }
    }
}
