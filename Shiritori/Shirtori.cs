using System;
using System.Collections.Generic;
using System.Linq;

namespace Shiritori
{
    internal class Shirtori
    {


        public List<string> words;
        public bool GAMEOVER;
        public Shirtori()
        {
            words=new List<string>();
            GAMEOVER = false;
        }
        public string[] Game(string word)
        {
            if (GAMEOVER)
            {
                return words.ToArray();
            }

            if (words.Count > 0)
            {
                string lastWord = words[words.Count - 1];

                if (word == lastWord || words.Contains(word))
                {
                    GAMEOVER = true;
                    Console.WriteLine("Game Over");
                    Console.Write("Shirtori Words: ");
                    return words.ToArray();
                }

                if (word[0] == lastWord[lastWord.Length - 1])
                {
                    words.Add(word);
                    return words.ToArray();
                }
            }
            else
            {
                words.Add(word);
                return words.ToArray();
            }

            GAMEOVER = true;
            Console.WriteLine("Game Over");
            Console.Write("Shirtori Words: ");
            return words.ToArray();
        }

        public string RESTART()
        {
            words.Clear();
            GAMEOVER = false;
            return "GAME RESTART...";
        } 
     
    }
}
