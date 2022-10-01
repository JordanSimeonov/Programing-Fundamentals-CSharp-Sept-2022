
namespace Pokemon
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int initialPokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int targetCount = 0;
            int pokePower = initialPokePower;

            while (pokePower >= distance)
            {
                pokePower -= distance;
                targetCount++;
                if (pokePower == initialPokePower * 0.50 && exhaustionFactor != 0)
                {
                        pokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(targetCount);
        }
    }
}
