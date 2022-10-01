
namespace WaterOverflow
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int tankCapacity = 255;
            int litersRecieved = 0;

            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                litersRecieved += liters;
                if (tankCapacity < litersRecieved)
                {
                    litersRecieved -= liters;
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                } 
            }
            Console.WriteLine(litersRecieved);
        }
    }
}
