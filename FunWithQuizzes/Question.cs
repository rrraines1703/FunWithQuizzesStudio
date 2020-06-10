using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    class Question
    {
        public string Prompt { get; set; }
        public string CorrectAnswer { get; set; }


        public Question(string prompt, string correctAnswer)
        {
            Prompt = prompt;
            CorrectAnswer = correctAnswer;
        }

        public virtual void DisplayQuestion()
        {
            Console.WriteLine(Prompt);
        }

        public static bool IsCorrect(Question question, string input)
        {
            return input == question.CorrectAnswer;
        }
    }
}
