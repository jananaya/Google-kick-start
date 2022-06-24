using System;

namespace InterestingIntegers
{
    internal class Solution
    {
        private static long SumDigitsOf(long n)
        {
            long sum = 0;
            string str = n.ToString();

            foreach (var number in str)
            {
                sum += (long)Char.GetNumericValue(number);
            }

            return sum;
        }

        private static long ProductDigitsOf(long n)
        {
            long product = 1;
            string str = n.ToString();

            foreach (var number in str)
            {
                product *= (long)Char.GetNumericValue(number);
            }

            return product;
        }


        public static bool IsInteresting(long n)
        {
            return Solution.ProductDigitsOf(n) % Solution.SumDigitsOf(n) == 0;
        }
    }

    internal class Program
    {
        public static void Run()
        {
            int numTestCases = int.Parse(Console.ReadLine() ?? "0");
            long[] output = new long[numTestCases];

            for (int i = 0; i < numTestCases; i++)
            {
                string[]? input = Console.ReadLine()?.Split(" ");
                long interestingCounter = 0;

                if (input == null)
                {
                    output[i] = interestingCounter;
                    continue;
                }

                long a = long.Parse(input[0]);
                long b = long.Parse(input[1]);

                for (long j = a; j <= b; j++)
                {
                    if (Solution.IsInteresting(j))
                    {
                        interestingCounter++;
                    }
                }

                output[i] = interestingCounter;
            }

            for (int i = 0; i < numTestCases; i++)
            {
                Console.WriteLine($"Case #{i + 1}: {output[i]}");
            }
        }
    }
}
