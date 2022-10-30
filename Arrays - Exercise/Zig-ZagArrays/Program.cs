
namespace Zig_ZagArrays
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 1; i <= n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                int firstNum = numbers[0];
                int secondNum = numbers[1];

                if (i % 2 != 0)
                {
                    firstArr[i - 1] = firstNum;
                    secondArr[i - 1] = secondNum;
                }
                else
                {
                    secondArr[i - 1] = firstNum;
                    firstArr[i - 1] = secondNum;
                }
            }
            Console.WriteLine(String.Join(" ", firstArr));
            Console.WriteLine(String.Join(" ", secondArr));
        }
    }
}
