namespace Exercises
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CallMenu();
        }

        public static void CallMenu()
        {
            PrintSum sumNumber = new PrintSum();
            sumNumber.RequestInput();
        }
    }
}