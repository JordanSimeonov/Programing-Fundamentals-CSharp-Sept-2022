
namespace SpiceMustFlow
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            int daysOperated = 0;
            int totalSpice = 0;

            while (startingYield >= 100)
            {
                daysOperated++;
                totalSpice = (totalSpice + startingYield) - 26;
                startingYield -= 10;
            }

            if (totalSpice > 26)
            {
                totalSpice -= 26;
            }
            Console.WriteLine(daysOperated);
            Console.WriteLine(totalSpice);
        }
    }
}
