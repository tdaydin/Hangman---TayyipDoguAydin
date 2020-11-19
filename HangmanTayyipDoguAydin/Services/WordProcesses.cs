using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanTayyipDoguAydin.Services
{
    class WordProcesses
    {
        string _output;
        int _errorCount;

        public string wordSelection(string sentence)
        {
            Random random = new Random();

            char[] sperator = { ' ' };
            string[] wordList = sentence.Split(sperator, StringSplitOptions.RemoveEmptyEntries);
            int number = wordList.Length;
            int randomNumber = random.Next(0, number);

            return wordList[randomNumber];
        }

        public string initialStars(string word)
        {
            _output = null;


            for (int i = 0; i < word.Length; i++)
            {
                _output += "*";
            }

            return _output;
        }


        public string numberOfStars(string word, char character)
        {

            int index;
            string holder = null;

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == character)
                {
                    index = word.IndexOf(character);
                    holder += i;

                }
            }

            if (holder != null)
            {
                string replace = Convert.ToString(character);
                int go;

                for (int i = 0; i < holder.Length; i++)
                {
                    int.TryParse(Convert.ToString(holder[i]), out go);
                    _output = _output.Remove(go, 1);
                    _output = _output.Insert(go, replace);
                }
                
            }
            else
            {
                _errorCount += 1;
            }

            return _output;
        }

        public int errorCount()
        {
            
            return _errorCount;
        }

        public string hangMan(int numberWrongGuess)
        {
            string[] body =
            {
                "    O   ",
                "   |    ", "   / |    ", "   / | \\    ",
                "   /    ","    / \\   "
            };

            return body[numberWrongGuess - 1];
        }
    }
}
