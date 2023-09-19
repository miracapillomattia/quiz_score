using System.Collections.Generic;
using System.Linq;

namespace RandazzoExam
{
    public class Question
    {
        
        private readonly string _text;
        private readonly List<Answer> _answers;


        private int _score = 0;
        
        public Question(string text, List<Answer> answers)
        {
            _text = text;
            _answers = answers;
        }

        public List<Answer> Answers => _answers;

        public string Text => _text;

        public int Score => _score;
        
        public void Valuta(string letter)
        {
            if (_answers.First(a => a.Letter == letter).Correct)
            {
                _score++;
            }
        }
    }
}
        
 