using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Heads_and_Tails
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> inputs = new List<char>();

            Console.WriteLine("Enterh \"H\" for heads or \"T\" for Tails");
            string ch = Console.ReadLine().Trim();
            char[] strToChar = ch.ToCharArray();

            for (int i = 0; i < strToChar.Length; i++)
            {
                inputs.Add(strToChar[i]);
            }

            int counter = 1;
            string elem = String.Empty;
            int maxElement = 1;

            // loop the List characters
            for (int i = 0; i < inputs.Count - 1; i++)
            {
                // count neighboring characters
                if (inputs[i] == inputs[i + 1])
                {
                    counter++;

                    // save the longest line of one character.
                    if (counter > maxElement)
                    {
                        maxElement = counter;
                        elem = inputs[i].ToString();
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            // Show DRAW if two characters are equal.
            if (counter == maxElement)
            {
                Console.WriteLine("Draw");
            }
            else
            {
                Console.WriteLine("Winner element is {0}", elem);
            }
        }
    }
}
