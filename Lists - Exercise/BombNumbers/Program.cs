﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string[] command = Console.ReadLine()
                .Split();

            int bombNumber = int.Parse(command[0]);
            int bombPower = int.Parse(command[1]);

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int start = i - bombPower;
                    if (start < 0)
                    {
                        start = 0;
                    }

                    int finish = i + bombPower + 1;
                    if (finish > numbers.Count)
                    {
                        finish = numbers.Count;
                    }

                    for (int j = start; j < finish; j++)
                    {
                        numbers[j] = 0;
                    }
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
