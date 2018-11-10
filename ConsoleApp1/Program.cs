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
            Menu call = new Menu();
            call.MenuDisplay();
        }
    }
}