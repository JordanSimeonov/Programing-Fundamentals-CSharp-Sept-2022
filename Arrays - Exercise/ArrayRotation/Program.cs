
namespace ArrayRotation
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int rotations = int.Parse(Console.ReadLine());
            int timesToRotate = rotations % arr.Length;

            for (int r = 1; r <= timesToRotate; r++)
            {
                string fisrtSymbol = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    arr[i - 1] = arr[i];
                }
                arr[arr.Length - 1] = fisrtSymbol;
                
            }
            Console.WriteLine(String.Join(" ", arr));
        }
    }
}
