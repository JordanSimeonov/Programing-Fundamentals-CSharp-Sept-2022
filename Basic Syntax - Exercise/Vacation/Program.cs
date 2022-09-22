
namespace Vacation
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double pricePerPerson = 0;
            double totalPrice = 0;
            int countOfPeopleBusiness = countOfPeople;

            if (typeOfGroup == "Students")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 8.45;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 9.80;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 10.46;
                }
                if (countOfPeople >= 30)
                {
                    pricePerPerson *= 0.85;
                }

                totalPrice = pricePerPerson * countOfPeople;
            }
            else if (typeOfGroup == "Business")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 10.90;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 15.60;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 16.00;
                }
                if (countOfPeople >= 100)
                {
                    countOfPeopleBusiness -= 10;
                }

                totalPrice = countOfPeopleBusiness * pricePerPerson;

            }
            else if (typeOfGroup == "Regular")
            {
                if (day == "Friday")
                {
                    pricePerPerson = 15.00;
                }
                else if (day == "Saturday")
                {
                    pricePerPerson = 20;
                }
                else if (day == "Sunday")
                {
                    pricePerPerson = 22.50;
                }
                if (countOfPeople >= 10 && countOfPeople <= 20)
                {
                    pricePerPerson *= 0.95;
                }

                totalPrice = countOfPeople * pricePerPerson;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
