namespace SinGala.BusinessHelper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartingMenu();
        }

        public static void StartingMenu()
        {
            Console.Clear();
            Console.WriteLine("What do you need help with?\n" +
                              "1 - Calculating revenue from a Fiverr order");

            ConsoleKeyInfo input = Console.ReadKey();

            if (input.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
            else if (input.KeyChar == '1')
            {
                FiverrRevenueCalculations.CalculatingFiverrRevenue();
            }
            else
            {
                StartingMenu();
            }
        }
    }
}