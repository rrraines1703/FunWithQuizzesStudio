using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    class MultipleChoice : Checkbox
    {
        public MultipleChoice(string prompt, string correctAnswer, string[] answers) : base(prompt, correctAnswer, answers) { }

        public override void DisplayQuestion()
        {
            Console.WriteLine("Select the correct answers");
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
