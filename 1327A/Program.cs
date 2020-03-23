using System;
using System.Linq;

namespace _1327
{
    class Program
    {
        public static int GetInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public static int[] GetIntArray(char inSeparator = ' ')
        {
            return Console.ReadLine().Split(inSeparator).Select(int.Parse).ToArray();
        }

        public static bool CanSumByOdd(int n, long k)
        {
            if (k == 1)
            {
                return n % 2 == 1;
            }

            var sum = (2 + 2 * (k - 1)) * k / 2;
            return (n - sum >= 0) && (n - sum) % 2 == 0;
        }

        static void Main(string[] args)
        {
            var t = GetInt();
            for (int i = 0; i < t; i++)
            {
                var inputData = GetIntArray();
                int n = inputData[0], k = inputData[1];
                Console.WriteLine(CanSumByOdd(n, k) ? "YES" : "NO");
            }
        }
    }
}
