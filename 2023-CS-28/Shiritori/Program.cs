using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shiritori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shirtori shritoriGame = new Shirtori();

            while (true)
            {
                Console.WriteLine("Enter a word (type \"exit\" to quit):");
                string input = Console.ReadLine();

       
                string[] currentWords = shritoriGame.Game(input);

                Console.WriteLine("Current Shritori Words:");
                foreach (var word in currentWords)
                {
                    Console.Write(word + " ");
                }

                Console.WriteLine();

                if (shritoriGame.GAMEOVER)
                {
                    Console.WriteLine("Game Over!");
                    Console.WriteLine("Do you want to restart? (yes/no)");

                    string restartInput = Console.ReadLine().ToLower();
                    if (restartInput == "yes")
                    {
                        shritoriGame.RESTART();
                        Console.WriteLine("Game Restarted.");
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }

}

   