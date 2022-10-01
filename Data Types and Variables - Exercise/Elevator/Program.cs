
namespace Elevator
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int numFullCourses = numOfPeople / capacity;
            int additionalCourse = 0;
            if (numOfPeople % capacity != 0)
            {
                additionalCourse = numOfPeople % capacity;
                numFullCourses += 1;
                Console.WriteLine(numFullCourses);
            }
            else if (numFullCourses == 1)
            {
                Console.WriteLine(numFullCourses);
            }
            else
            {
                Console.WriteLine(numFullCourses);
            }

        }
    }
}
