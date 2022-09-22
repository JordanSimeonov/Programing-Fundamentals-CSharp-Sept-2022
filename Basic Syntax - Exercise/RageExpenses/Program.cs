
namespace RageExpenses
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetCount = 0;
            int mouseCount = 0;
            int keyboardCount = 0;
            int displayCount = 0;

            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0 || i % 4 == 0 || i % 6 == 0 || i % 8 == 0 || i % 10 ==0 || i % 12 == 0)
                {
                    headsetCount++;
                }
                if (i % 3 == 0 || i % 6 == 0 || i % 9 == 0 || i % 12 == 0)
                {
                    mouseCount++;
                }
                if (i % 6 == 0 || i % 12 == 0)
                {
                    keyboardCount++;
                }
                if (i % 12 == 0)
                {
                    displayCount++;
                }
            }

            double rageExpenses = (headsetCount * headsetPrice) + (mouseCount * mousePrice)
                           + (keyboardCount * keyboardPrice) + (displayCount * displayPrice);
            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}
