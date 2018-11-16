using System;

namespace Exercises
{
    public class TimesTables
    {
        private int[] firstNum = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        private int f, sum;

        public int Incrementor()
        {
            Console.Clear();
            Console.WriteLine("***** Multiplication Table *****");
            Console.WriteLine("This is the multiplication table from one to 12.");
            Console.WriteLine("For larger numbers, guess.  Or buy a calculator, lazy!");
            for (f = 1; f <= 12; f++)
            {
                foreach (int s in firstNum)
                {
                    sum = s * f;
                    Console.Write("{0}\t", sum);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Press ENTER to return to the main menu.");
            Console.ReadLine();
            return sum;
        }
    }
}