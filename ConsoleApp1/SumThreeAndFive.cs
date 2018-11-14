using System;

namespace Exercises
{
    internal class SumThreeAndFive
    {
        private int numberToSum, sum = 0, a, b;

        public int ThreeFiveInput()
        {
            Console.Clear();
            Console.WriteLine("***** The 3 And 5 Exercise *****");
            Console.WriteLine("Enter a number and I will add up the sum");
            Console.WriteLine("of all numbers that are multiples of 3 and 5:");
            numberToSum = int.Parse(Console.ReadLine());

            for (int n = 1; n <= numberToSum; n++)
            {
                a = n % 3;
                b = n % 5;
                if (a == 0 || b == 0)
                {
                    Console.Write("{0}\t", n);
                    sum = sum + n;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The sum of all numbers that are divisible ");
            Console.WriteLine("by 3 or 5 in " + numberToSum + " is " + sum + ".");
            Console.WriteLine("Press ENTER to return to the main menu.");
            Console.ReadLine();
            return numberToSum;
        }
    }
}