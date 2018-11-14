using System;
using System.Collections.Generic;

namespace Exercises
{
    public class Product
    {
        private int product;

        public void FindProduct()
        {
            Console.Clear();
            Console.WriteLine("***** Product Generator *****");
            Console.WriteLine("Give me two numbers.");
            Console.WriteLine("First number:");
            int numOne = int.Parse(Console.ReadLine());
            Console.WriteLine("And the second number:");
            int numTwo = int.Parse(Console.ReadLine());

            Console.WriteLine("I will take " + numOne + " and multiply it by all numbers from 1 to " + numTwo + ".");

            List<int> lst = new List<int>();
            for (int n = 1; n <= numTwo; n++)
            {
                lst.Add(n);
            }

            foreach (int num in lst)
            {
                product = num * numOne;
                Console.Write("{0}\t", product);
            }

            Console.WriteLine();
            Console.WriteLine("Press ENTER to return to the main menu.");
            Console.ReadLine();
        }
    }
}