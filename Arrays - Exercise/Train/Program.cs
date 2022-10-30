
namespace Train
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numWagons = new int[n];
            int totalPeople = 0;

            for (int i = 0; i < numWagons.Length; i++)
            {
                numWagons[i] = int.Parse(Console.ReadLine());
                totalPeople += numWagons[i];
            }
            Console.WriteLine(String.Join(" ", numWagons));
            Console.WriteLine(totalPeople);
        }
    }
}
