using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string input = "";

            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split(" ");

                if (cmdArgs[0] == "Add")
                {
                    int numberToAdd = int.Parse(cmdArgs[1]);
                    numbers.Add(numberToAdd);
                }
                else if (cmdArgs[0] == "Insert")
                {
                    int numberToInsert = int.Parse(cmdArgs[1]);
                    int index = int.Parse(cmdArgs[2]);

                    if (IsIndexInvalid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(index, numberToInsert);
                }
                else if (cmdArgs[0] == "Remove")
                {
                    int index = int.Parse(cmdArgs[1]);

                    if (IsIndexInvalid(numbers, index))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(index);
                }
                else if (cmdArgs[0] == "Shift")
                {
                    int count = int.Parse(cmdArgs[2]);

                    if (cmdArgs[1] == "left")
                    {
                        ShiftListLeft(numbers, count);
                    }
                    else if (cmdArgs[1] == "right")
                    {
                        ShiftListRight(numbers, count);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void ShiftListRight(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNumber);
            }
        }

        private static void ShiftListLeft(List<int> numbers, int count)
        {
            for (int i = 0; i < count; i++)
            {
                int firstNumber = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNumber);
            }
        }

        static bool IsIndexInvalid(List<int> numbers, int index)
            => index < 0 || index >= numbers.Count;
    }
}
