using System.Collections.Generic;
using RandazzoExam;

namespace RandazzoExam
{
    public class Exam
    {
        private List<Question> _questions = new List<Question>();
        
        public Exam()
        {
            Question.Add(new Question("1) Qual è il termine che descrive la creazione di un nuovo tipo di dato basato su uno già esistente in C#?", new List<Answer>()
            {
                new Answer("a", "Generics", false),
                new Answer("b", "Inheritance", true),
                new Answer("c", "Composition", false),
                new Answer("d", "Structuring", false)
                
            }));
            
            Question.Add(new Question("2) Quale parola chiave viene utilizzata per definire un membro di classe che può essere accessibile solo da classi derivate in C#?", new List<Answer>()
            {
                new Answer("a", "Private", false),
                new Answer("b", "Protected", true),
                new Answer("c", "Internal", false),
                new Answer("d", "Sealed", false)
                
            }));
            
            Question.Add(new Question("3) Quale parola chiave viene utilizzata per definire una classe che non può essere istanziata in C#?", new List<Answer>()
            {
                new Answer("a", "Abstract", true),
                new Answer("b", "Static", false),
                new Answer("c", "Virtual", false),
                new Answer("d", "Sealed", false)
                
            }));
            
            Question.Add(new Question("4) Quale concetto descrive la possibilità di definire più metodi con lo stesso nome ma con diversi parametri in una classe in C#?", new List<Answer>()
            {
                new Answer("a", "Polimorfismo", false),
                new Answer("b", "Overloading", true),
                new Answer("c", "Overriding", false),
                new Answer("d", "Ereditarietà", false)
                
            }));
            
            Question.Add(new Question("5) Quale parola chiave viene utilizzata per consentire a una classe di ereditare da una sola classe base in C#?", new List<Answer>()
            {
                new Answer("a", "this", true),
                new Answer("b", "base", false),
                new Answer("c", "static", false),
                new Answer("d", "hidden", false)
                
            }));
        }

        public List<Question> Question => _questions;


        public int EvaluationScore(List<string> answers)
        {
            int result = 0;
            int index = 0;
            foreach (var answer in answers)
            {

                _questions[index].Valuta(answer);
                result = result + _questions[index].Score;
                index++;
            }

            return result;
        }

        
    }
}
 