
namespace Divison
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int devider = 0;

            if (number % 10 == 0)
            {
                devider = 10; 
            }
            else if (number % 7 == 0)
            {
                devider = 7;
            }
            else if (number % 6 == 0)
            {
                devider = 6;
            }
            else if (number % 3 == 0)
            {
                devider = 3;
            }
            else if (number % 2 == 0)
            {
                devider = 2;
            }
            else
            {
                Console.WriteLine("Not divisible");
            }

            if (devider != 0)
            {
                Console.WriteLine($"The number is divisible by {devider}");
            }
        }
    }
}
