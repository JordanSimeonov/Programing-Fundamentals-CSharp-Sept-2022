
namespace Snowballs
{
    using System;
    using System.Numerics;


    class Program
    {
        static void Main(string[] args)
        {
            int numSnowballs = int.Parse(Console.ReadLine());

            BigInteger snowBallValue = BigInteger.MinusOne;
            int maxSnow = 0;
            int maxTime = 0;
            int maxQuality = 0;

            for (int i = 0; i < numSnowballs; i++)
            {
                int snowBallSnow = int.Parse(Console.ReadLine());
                int snowBallTime = int.Parse(Console.ReadLine());
                int snowBallQuality = int.Parse(Console.ReadLine());
                BigInteger value = BigInteger.Pow(snowBallSnow / snowBallTime, snowBallQuality); ;

                if (value > snowBallValue)
                {
                    snowBallValue = value;
                    maxSnow = snowBallSnow;
                    maxTime = snowBallTime;
                    maxQuality = snowBallQuality;
                }
            }
            Console.WriteLine($"{maxSnow} : {maxTime} = {snowBallValue} ({maxQuality})");
        }
    }
}
