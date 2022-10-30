using System;
using System.Linq;

namespace P10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] field = new int[fieldSize];

            int[] initialLadyBugsIndexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < initialLadyBugsIndexes.Length; i++)
            {
                int currIndex = (initialLadyBugsIndexes[i]);

                if (currIndex >= 0 && currIndex < field.Length)
                {
                    field[currIndex] = 1;
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int ladyBugIndex = int.Parse(cmdArgs[0]);
                string direction = cmdArgs[1];
                int flyLenght = int.Parse(cmdArgs[2]);

                if (ladyBugIndex < 0 || ladyBugIndex >= field.Length)
                {
                    continue;
                }

                if (field[ladyBugIndex] == 0)
                {
                    continue;
                }

                field[ladyBugIndex] = 0;

                if (direction == "left")
                {
                    flyLenght *= -1;
                }

                int nextIndex = ladyBugIndex + flyLenght;

                while (nextIndex >= 0 && nextIndex < field.Length && field[nextIndex] == 1)
                {
                    nextIndex += flyLenght;
                }

                if (nextIndex < 0 || nextIndex >= field.Length)
                {
                    continue;
                }

                field[nextIndex] = 1;
            }   

            Console.WriteLine(string.Join(" ", field));
        }
    }
}
