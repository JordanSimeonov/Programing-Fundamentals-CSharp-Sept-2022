using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNum = long.Parse(Console.ReadLine());
            long secondNum = long.Parse(Console.ReadLine());
            long thirdNum = long.Parse(Console.ReadLine());
            long fourthNum = long.Parse(Console.ReadLine());

            long result = ((firstNum + secondNum) / thirdNum) * fourthNum;

            Console.WriteLine(result);
        }
    }
}
