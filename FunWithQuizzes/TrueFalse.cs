using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithQuizzes
{
    class TrueFalse : Question
    {
        public TrueFalse(string prompt, string correctAnswer) : base(prompt, correctAnswer)
        {

        }

        public override void DisplayQuestion()
        {
            Console.WriteLine("True or False");
            Console.WriteLine(Prompt);
        }
    }
}
