using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input.Split(" ");

                string command = cmdArgs[0];

                if (command == "Delete")
                {
                    int numberToDelete = int.Parse(cmdArgs[1]);
                    numbers.RemoveAll(n => n == numberToDelete);
                }
                else if (command == "Insert")
                {
                    int elementToInsert = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);
                    numbers.Insert(index, elementToInsert);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
