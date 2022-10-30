using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> stringNumbers = Console.ReadLine()
            //     .Split('|')
            //     .Reverse()
            //     .ToList();
            //string temp = string.Join(" ", stringNumbers);
            //List<string> result = temp.Split(" ", StringSplitOptions.RemoveEmptyEntries)
            //    .ToList();

            //Console.WriteLine(string.Join(" ", result));

            List<string> input = Console.ReadLine()
                .Split('|')
                .Reverse()
                .ToList();

            List<string> result = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                List<string> numbers = input[i]
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                for (int k = 0; k < numbers.Count; k++)
                {
                    result.Add(numbers[k]);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
