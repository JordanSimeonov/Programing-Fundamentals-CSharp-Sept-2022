
namespace PadawanEquipment
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());

            int freeBelt = countOfStudents / 6;
            double totalLightsabersPrice = Math.Ceiling(countOfStudents * 1.1) * lightsabersPrice;
            double totalRobesPrice = countOfStudents * robesPrice;
            double totalBletsPrice = (countOfStudents - freeBelt) * beltsPrice ;

            double totalPrice = totalLightsabersPrice + totalRobesPrice + (totalBletsPrice);

            if (money >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else if (money < totalPrice)
            {
                Console.WriteLine($" John will need {totalPrice - money:F2}lv more.");
            }
        }
    }
}
