using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    class Quiz
    {
        private List<string> UserAnswers = new List<string>();
        public List<Question> QuizQuestions = new List<Question>();
        public Quiz(List<Question> questions)
        {
            QuizQuestions = questions;
        }

        public void AddAnswers(string input)
        {
            UserAnswers.Add(input);
        }

        public void AddQuestion(Question newQuestion)
        {
            QuizQuestions.Add(newQuestion);
        }

        public void DisplayQuiz()
        {
            foreach (Question question in QuizQuestions)
            {
                Console.WriteLine("");
                question.DisplayQuestion();
                UserAnswers.Add(Console.ReadLine());
            }
        }

        public int GradeQuiz()
        {
            int score = 0;
            int i = 0;
            foreach (Question question in QuizQuestions)
            {
                Console.WriteLine($"Correct Answer: {question.CorrectAnswer}");
                Console.WriteLine($"User Answer: {UserAnswers[i]}");
                if (Question.IsCorrect(question, UserAnswers[i]))
                {
                    Console.WriteLine("Correct");
                    score++;
                }
                i++;
            }
            return score;
        }
    }
}
