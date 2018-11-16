using System;

namespace Exercises
{
    public class Menu
    {
        public void MenuDisplay()
        {
            string menuInput;

            do
            {
                Console.Clear();
                Console.WriteLine("================================================");
                Console.WriteLine("Which C# skills exercise would you like to try?");
                Console.WriteLine("Sum of given number.                         (1)");
                Console.WriteLine("Sum of 3 and 5 multiples for a given number. (2)");
                Console.WriteLine("Generate product of a given number.          (3)");
                Console.WriteLine("Multiplication table.                        (4)");
                Console.WriteLine("List a whole lotta prime numbers.            (5)");
                /*Console.WriteLine("                                (6)");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();*/
                Console.WriteLine("================================================");
                Console.WriteLine();
                Console.Write("Enter choice:");
                menuInput = Console.ReadLine();

                switch (menuInput)
                {
                    case "1":
                        PrintSum newSum = new PrintSum();
                        newSum.RequestInput();
                        break;

                    case "2":
                        SumThreeAndFive tfsum = new SumThreeAndFive();
                        tfsum.ThreeFiveInput();
                        break;

                    case "3":
                        Product gen = new Product();
                        gen.FindProduct();
                        break;

                    case "4":
                        TimesTables mult = new TimesTables();
                        mult.Incrementor();
                        break;

                    case "5":
                        PrimeNumbers prime = new PrimeNumbers();
                        prime.CalcPrime();
                        break;

                    case "6":

                        break;
                }
            } while (true);
        }

        public void NumberSum()
        {
            PrintSum newSum = new PrintSum();
            newSum.RequestInput();
        }
    }
}