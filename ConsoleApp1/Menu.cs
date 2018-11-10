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
                Console.WriteLine("Sum of given number.            (1)");
                /* Console.WriteLine("                                (2)");
                 Console.WriteLine("                                (3)");
                 Console.WriteLine("                                (4)");
                 Console.WriteLine("                                (5)");
                 Console.WriteLine("                                (6)");
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
                        Console.WriteLine("The Sum Calculator");
                        PrintSum newSum = new PrintSum();
                        newSum.RequestInput();
                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":

                        break;
                    case "5":

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