using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuizApp
{
    public enum QuestionLevel
    {
        Easy, Medium, Hard
    }
    internal class Question
    {
        public string Text;
        public string[] Choices;
        public int CorrectAnswer;
        public QuestionLevel Level;

        public Question(string Text, string[] Choices, int CorrectAnswer, QuestionLevel Level)
        {
            this.Text = Text;
            this.Choices = Choices;
            this.CorrectAnswer = CorrectAnswer;
            this.Level = Level;
        }
        
        public virtual bool CheckAnswer(int UserAnswer)
        {
            return UserAnswer == CorrectAnswer;


        }
    }
}