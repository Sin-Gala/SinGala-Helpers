namespace SinGala.BusinessHelper
{
    internal class FiverrRevenueCalculations
    {
        private const float FIVERR_PERCENTAGE = 20f;
        private const float URSAFF_PERCENTAGE = 24f;

        public static void CalculatingFiverrRevenue()
        {
            Console.Clear();

            Console.WriteLine("Is the order in Euros? Y/N: ");
            ConsoleKeyInfo input = Console.ReadKey();

            if (input.Key == ConsoleKey.Y)
            {
                CalculateFromEuros();
            }
            else if (input.Key == ConsoleKey.N)
            {
                CalculateFromAmericanDollars();
            }
            else
            {
                CalculatingFiverrRevenue();
            }
        }

        private static void CalculateFromEuros()
        {
            Console.Clear();
            Console.WriteLine("What is the amount: ");
            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                CalculateFromEuros();
                return;
            }

            Console.Clear();

            float amount = float.Parse(input);

            float takenByFiverr = (float)Math.Round((amount * FIVERR_PERCENTAGE) / 100, 2);
            float takenByUrsaff = (float)Math.Round((amount * URSAFF_PERCENTAGE) / 100, 2);

            float leftAfterFiverr = (float)Math.Round(amount - takenByFiverr, 2);

            float totalAmountLeft = amount - takenByFiverr - takenByUrsaff;

            Console.WriteLine("Revenue calculated: \n" +
                              "- Base Revenue = " + amount + "Euros\n" +
                              "- Taken by Fiverr = " + takenByFiverr + "Euros\n" +
                              "- Amount after Fiverr = " + leftAfterFiverr + "Euros\n" +
                              "- Taken by Ursaff = " + takenByUrsaff + "Euros\n" +
                              "- TOTAL LEFT: " + totalAmountLeft + "Euros");

            Console.ReadKey();

            Program.StartingMenu();
        }

        private static void CalculateFromAmericanDollars()
        {
            Console.Clear();
            Console.WriteLine("What is the current conversion rate from US Dollar to Euros: ");

            string? input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                CalculateFromAmericanDollars();
                return;
            }

            Console.Clear();

            float convRate = float.Parse(input);

            Console.WriteLine("What is the amount: ");
            input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || string.IsNullOrWhiteSpace(input))
            {
                CalculateFromAmericanDollars();
                return;
            }

            Console.Clear();

            float amount = float.Parse(input);
            float amountEuro = amount * convRate;

            float takenByFiverr = (float)Math.Round((amount * FIVERR_PERCENTAGE) / 100, 2);
            float takenByUrsaff = (float)Math.Round((amountEuro * URSAFF_PERCENTAGE) / 100, 2);

            float leftAfterFiverrDollars = (float)Math.Round(amount - takenByFiverr, 2);
            float leftAfterFiverrEuros = (float)Math.Round(amount * convRate, 2);

            float totalAmountLeft = leftAfterFiverrEuros - takenByUrsaff;

            Console.WriteLine("Revenue calculated: \n" +
                              "- Conversion Rate: " + convRate + "\n" +
                              "- Base Revenue US Dollars = " + amount + "\n" +
                              "- Base Revenue = " + amountEuro + "Euros\n" +
                              "- Taken by Fiverr = " + takenByFiverr + "Dollars\n" +
                              "- Amount after Fiverr = " + leftAfterFiverrDollars + "Dollars\n" +
                              "- Amount after Fiverr = " + leftAfterFiverrEuros + "Euros\n" +
                              "- Taken by Ursaff = " + takenByUrsaff + "Euros\n" +
                              "- TOTAL LEFT: " + totalAmountLeft + "Euros");

            Console.ReadKey();

            Program.StartingMenu();
        }
    }
}
