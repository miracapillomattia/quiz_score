using System;
using System.Collections.Generic;
using Quiz;

namespace RandazzoExam
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RandazzoExam.Exam q = new RandazzoExam.Exam();

            List<string> answers = new List<string>();

            foreach (var question in q.Question)
            {
                Console.WriteLine(question.Text);
                foreach (var answer in question.Answers)
                {
                    Console.WriteLine(answer.Letter + ") " + answer.Text);
                }

                Console.WriteLine("Inserisci la risposta");
                string answerUser = Console.ReadLine();
                answers.Add(answerUser);

            }

            Console.WriteLine("Il tuo punteggio è: " + q.EvaluationScore(answers) + " su " + "5" + " domande complessive");

        }


    }
}

    