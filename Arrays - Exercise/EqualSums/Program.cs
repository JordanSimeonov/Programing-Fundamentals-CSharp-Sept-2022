
namespace EqualSums
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
                int leftSum = 0;
                int rightSum = 0;

                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }
                for (int k = 0; k < i; k++)
                {
                    leftSum += numbers[k];
                }
                if (rightSum == leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
