
namespace SumofChars
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                char letter = Console.ReadLine()[0];
                sum += (int)letter;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
