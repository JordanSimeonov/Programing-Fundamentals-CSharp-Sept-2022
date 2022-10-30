using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPLayer = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondPLayer = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                if (firstPLayer[0] > secondPLayer[0])
                {
                    firstPLayer.Add(firstPLayer[0]);
                    firstPLayer.Add(secondPLayer[0]);
                }
                else if (secondPLayer[0] > firstPLayer[0])
                {
                    secondPLayer.Add(secondPLayer[0]);
                    secondPLayer.Add(firstPLayer[0]);
                }

                firstPLayer.Remove(firstPLayer[0]);
                secondPLayer.Remove(secondPLayer[0]);

                if (firstPLayer.Count == 0)
                {
                    int sum = secondPLayer.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;
                }
                else if (secondPLayer.Count == 0)
                {
                    int sum = firstPLayer.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
            }
        }
    }
}
