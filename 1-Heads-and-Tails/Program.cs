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


            for (int i = 0; i < inputs.Count - 1; i++)
            {
                // H H H T T T
                if (inputs[i] == inputs[i + 1])
                {
                    counter++;

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
