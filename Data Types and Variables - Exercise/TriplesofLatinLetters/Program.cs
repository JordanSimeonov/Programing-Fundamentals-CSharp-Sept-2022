
namespace TriplesofLatinLetters
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (char i = 'a'; i < 'a' + num; i++)
            {
                for (char k = 'a'; k < 'a' + num; k++)
                {
                    for (char j = 'a'; j < 'a' + num; j++)
                    {
                        Console.WriteLine($"{i}{k}{j}");
                    }
                }
            }
        }
    }
}
