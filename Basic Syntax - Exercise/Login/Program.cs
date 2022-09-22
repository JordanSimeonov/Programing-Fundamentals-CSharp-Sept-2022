
namespace Login
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = string.Empty;

            for (int i = userName.Length - 1; i >= 0; i--)
            {
                char curCh = userName[i];
                password += curCh;
            }

            int counter = 0;
            string input = string.Empty;

            while ((input = Console.ReadLine()) != password)
            {
                counter += 1;

                if (counter == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");
            }

            Console.WriteLine($"User {userName} logged in.");
        }
    }
}
