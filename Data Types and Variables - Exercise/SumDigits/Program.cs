
namespace SumDigits
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int currentNum = num;
            int sum = 0;
            while (currentNum > 0)
            {
                sum += currentNum % 10;
                currentNum /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
