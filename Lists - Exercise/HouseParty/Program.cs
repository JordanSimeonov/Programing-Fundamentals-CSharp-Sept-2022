using System;
using System.Collections.Generic;

namespace HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> guestList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = input[0];

                if (input.Length == 3) // "{name} is going!"
                {

                    if (guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                        continue;
                    }

                    guestList.Add(name);
                }

                else if (input.Length == 4)  // "{name} is not going!"
                {
                    if (!guestList.Contains(name))
                    {
                        Console.WriteLine($"{name} is not in the list!");
                        continue;
                    }

                    guestList.Remove(name);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, guestList));
        }
    }
}
