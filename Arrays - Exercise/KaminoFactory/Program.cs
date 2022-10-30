
namespace KaminoFactory
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());
            string command;

            int bestLength = 1;
            int bestStartIndex = 0;
            int bestSequenceSum = 0;
            int bestSequenceIndex = 0;

            int[] bestSequence = new int[dnaLength];

            int sequenceCounter = 0;

            while ((command = Console.ReadLine()) != "Clone them!")
            {
                int[] currentSequence = command
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                sequenceCounter++;

                int length = 1;
                int bestCurrentLength = 1;
                int startIndex = 0;
                int currentSequenceSum = 0;

                for (int i = 0; i < currentSequence.Length - 1; i++)
                {
                    if (currentSequence[i] == currentSequence[i + 1])
                    {
                        length++;
                    }
                    else
                    {
                        length = 1;
                    }

                    if (length > bestCurrentLength)
                    {
                        bestCurrentLength = length;
                        startIndex = i;
                    }

                    currentSequenceSum += currentSequence[i];
                }

                currentSequenceSum += currentSequence[dnaLength - 1];

                if (bestCurrentLength > bestLength)
                {
                    bestLength = bestCurrentLength;
                    bestStartIndex = startIndex;
                    bestSequenceSum = currentSequenceSum;
                    bestSequenceIndex = sequenceCounter;
                    bestSequence = currentSequence.ToArray();
                }
                else if (bestCurrentLength == bestLength)
                {
                    if (startIndex < bestStartIndex)
                    {
                        bestLength = bestCurrentLength;
                        bestStartIndex = startIndex;
                        bestSequenceSum = currentSequenceSum;
                        bestSequenceIndex = sequenceCounter;
                        bestSequence = currentSequence.ToArray();


                    }
                    else if (startIndex == bestStartIndex)
                    {
                        if (currentSequenceSum > bestSequenceSum)
                        {
                            bestLength = bestCurrentLength;
                            bestStartIndex = startIndex;
                            bestSequenceSum = currentSequenceSum;
                            bestSequenceIndex = sequenceCounter;
                            bestSequence = currentSequence.ToArray();


                        }
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}.");
            Console.WriteLine(String.Join(' ', bestSequence));
        }
    }
}
