using System;

namespace Exercises
{
    public class PrimeNumbers
    {
        public void CalcPrime()
        {
            Console.Clear();
            bool isPrime = true;
            Console.WriteLine("Prime numbers (Press any key to interrupt.) : ");
            for (int i = 2; i <= 1000000; i++)
            {
                for (int j = 2; j <= 1000000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("{0}\t", i);
                }
                if (i >= 500 && i <= 500)
                {
                    Console.WriteLine();
                    Console.WriteLine("Hope you packed a lunch.");
                }
                if (i >= 5000 && i <= 5000)
                {
                    Console.WriteLine();
                    Console.WriteLine("And maybe a dinner, too.");
                }
                if (i >= 11000 && i <= 11000)
                {
                    Console.WriteLine();
                    Console.WriteLine("Can I get you anything?  Coffee?");
                }
                if (i >= 30000 && i <= 30000)
                {
                    Console.WriteLine();
                    Console.WriteLine("Just to let you know, we close in ten minutes.");
                }
                if (i >= 700000 && i <= 700000)
                {
                    Console.WriteLine();
                    Console.WriteLine("Well, here are the keys, please lock up.");
                }
                isPrime = true;
            }

            Console.WriteLine("Press ENTER to return to the main menu.");
            Console.ReadLine();
        }
    }
}