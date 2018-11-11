using System;

namespace Exercises
{
    public class PrintSum
    {
        private int numberToSum, sum = 0;

        public int RequestInput()
        {
            Console.Clear();
            Console.WriteLine("Enter a number:");
            numberToSum = int.Parse(Console.ReadLine());

            for (int n = 1; n <= numberToSum; n++)
            {
                sum = sum + n;
            }
            Console.WriteLine("The sum of 1 to " + numberToSum + " is " + sum);
            Console.WriteLine("Press ENTER to return to the main menu.");
            Console.ReadLine();
            return numberToSum;
        }


    }
}