
namespace MaxSequenceofEqualElements
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int maxCount = 0;
            int count = 0;
            int start = 0;
 
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;
                    if (count > maxCount)
                    {
                        start = i - count;
                        maxCount = count;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            for (int i = start + 1; i <= start + maxCount + 1; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
