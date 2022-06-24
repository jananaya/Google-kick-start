using System;

namespace TransformTheString
{
    internal class Solution
    {
        private static bool IsAlphabetChar(char c)
        {
            return c >= 'a' && c <= 'z';
        }

        private static byte Alternative(char a, char b)
        {
            byte result = (byte)(Math.Abs(a - 'a') + Math.Abs(b - 'z') + 1);
            return result;
        }

        public static int CalculateDistance(char a, char b)
        {
            if (!IsAlphabetChar(a) || !IsAlphabetChar(b))
            {
                return -1;
            }

            int distance = Math.Abs(a - b);
            int alternative = a > b ? Alternative(b, a) : Alternative(a, b);

            return distance > alternative ? alternative : distance;
        }
    }

    internal class Program
    {
        public static void Run()
        {
            int testCases = int.Parse(Console.ReadLine() ?? "0");
            int[] output = new int[testCases];
            int numCase = 1;
            int counter = 0;

            while (testCases > 0)
            {
                string? s = Console.ReadLine();
                string? f = Console.ReadLine();
                int operations = 0;

                if (s == null || f == null)
                {
                    throw new NullReferenceException();
                }
                
                foreach (char c in s)
                {
                    if (!f.Contains(c))
                    {
                        int minDistance = int.MaxValue;

                        foreach (char character in f)
                        {
                            if (minDistance > Solution.CalculateDistance(c, character))
                            {
                                minDistance = Solution.CalculateDistance(c, character);
                            }
                        }

                        operations += minDistance;
                    }
                }

                output[counter++] = operations;
                testCases--;
            }

            foreach (int numOperations in output)
            {
                Console.WriteLine($"Case #{numCase++}: {numOperations}");
            }
        }
    }
}
