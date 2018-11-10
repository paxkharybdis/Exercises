using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Exercises
{
    public class PrintSum
    {
        int numberToSum;
        int sum = 0;
        //int summedUp;

        public int RequestInput()
        {
            Console.WriteLine("Enter a number:");
            numberToSum = int.Parse(Console.ReadLine());

            for (int n = 1; n <= numberToSum; n++)
            {
                sum = sum + n;
            }
            Console.WriteLine("The sum of 1 to " + numberToSum + " is " + sum);

            return numberToSum;



        }


        public void AddSum()
        {

            //return numberToSum;  
        }

    }
}
