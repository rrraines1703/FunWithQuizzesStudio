using System;
using System.Collections.Generic;

namespace FunWithQuizzes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Question> list = new List<Question>();

            Question question1 = new Question("What color is the sky?", "blue");
            list.Add(question1);

            TrueFalse question2 = new TrueFalse("There are nine planets.", "true");
            list.Add(question2);

            string[] temp = { "Cat", "Llama", "Dog" };
            Checkbox question3 = new Checkbox("Select the dog.", "3", temp);
            list.Add(question3);

            string[] temp2 = { "Cat", "Llama", "Dog", "Cow" };
            Checkbox question4 = new Checkbox("Select the pets.", "1,2", temp2);
            list.Add(question4);

            Quiz ourQuiz = new Quiz(list);

            ourQuiz.DisplayQuiz();

            Console.WriteLine(ourQuiz.GradeQuiz());
        }
    }
}
