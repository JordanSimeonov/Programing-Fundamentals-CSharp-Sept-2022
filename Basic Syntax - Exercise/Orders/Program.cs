
namespace Orders
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int i = 1; i <= n; i++)
            {
                double price = 0;

                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                price += capsulesCount * pricePerCapsule * days;

                Console.WriteLine($"The price for the coffee is: ${price:F2}");

                totalPrice += price;
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
