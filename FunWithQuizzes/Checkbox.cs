using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    class Checkbox : Question
    {
        public string[] Answers;

        public Checkbox(string prompt, string correctAnswer, string[] answers) : base(prompt, correctAnswer)
        {
            Answers = answers;
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine("Select the correct answer");
            Console.WriteLine(Prompt);
            int i = 1;
            foreach (string answer in Answers)
            {
                Console.WriteLine($"{i}. {answer}");
                i++;
            }
        }

    }
}
