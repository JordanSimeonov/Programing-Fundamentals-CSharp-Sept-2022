
namespace BeerKegs
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double volume = double.MinValue;
            string biggerKeg = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeCurrentKeg = Math.PI * Math.Pow(radius, 2) * height;

                if (volumeCurrentKeg > volume)
                {
                    volume = volumeCurrentKeg;
                    biggerKeg = model;
                }
            }
            Console.WriteLine(biggerKeg);
        }
    }
}
