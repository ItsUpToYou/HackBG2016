using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Lakes
{
    class Program
    {
        static void Main(string[] args)
        {
            int levelDown = 0;
            int levelUp = 0;
            int sum = 0;

            Console.WriteLine("Please input \"d\" for down level");
            Console.WriteLine("Please input \"u\" for up level");
            Console.WriteLine("Please input \"h\" for horizontal level");

            //read from console
            string inputChar = Console.ReadLine();

            // walking throughout the levels
            for (int i = 0; i < inputChar.Count(); i++)
            {
                if (inputChar[i] == 'd')
                {
                    if (levelUp > 1)
                    {
                        levelUp--;
                    }
                    else
                    {
                        //count and sum down-levels
                        levelDown++;
                        sum += 500 + (levelDown - 1) * 1000;
                    }
                }
                else if (inputChar[i] == 'u')
                {
                    if (levelDown > 0)
                    {
                        //count going up-levels and remove a level from "down"
                        levelDown--;
                        sum += 500 + (levelDown * 1000);
                        levelUp++;
                    }
                }
                // horizontal sum level
                else
                {
                    if (inputChar[i] == 'h')
                    {
                        sum += 1000 * levelDown;
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
