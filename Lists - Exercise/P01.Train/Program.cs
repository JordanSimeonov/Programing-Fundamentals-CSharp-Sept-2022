using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacityOFWagon = int.Parse(Console.ReadLine());

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = input.Split(" ");

                if (cmdArgs[0] == "Add")
                {
                    int addWagon = int.Parse(cmdArgs[1]);
                    wagons.Add(addWagon);
                }
                else
                {
                    int addPassangers = int.Parse(cmdArgs[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (addPassangers <= maxCapacityOFWagon - wagons[i]) 
                        {
                            wagons[i] += addPassangers;
                            break;
                        }
                       
                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
