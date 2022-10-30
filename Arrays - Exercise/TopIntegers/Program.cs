
namespace TopIntegers
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isGreater = true;
                int currNum = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (currNum <= numbers[j])
                    {
                        isGreater = false;
                        break;
                    }
                }
                if (isGreater)
                {
                    Console.Write($"{currNum} ");
                }
            }
        }
    }
}
