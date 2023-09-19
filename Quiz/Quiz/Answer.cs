namespace RandazzoExam
{
    public class Answer
    {
        private readonly string _letter;
            private readonly string _text;
            private readonly bool _correct;

            public Answer(string letter, string testo, bool corretta)
            {
                _letter = letter;
                _text = testo;
                _correct = corretta;
            }

            public bool Correct => _correct;

            public string Text => _text;

            public string Letter => _letter;
        }
    }
 