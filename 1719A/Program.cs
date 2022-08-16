using System;
using System.Linq;

namespace _1719A
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

        static void Main(string[] args)
        {
            var t = GetInt();
            for (int i = 0; i < t; i++)
            {
                var inputs = GetIntArray();
                var n = inputs[0];
                var m = inputs[1];
                var countN = n % 2 == 0 ? 1 : 0;
                var countM = m % 2 == 0 ? 1 : 0;
                Console.WriteLine((countM + countN) % 2 == 0 ? "Tonya" : "Burenka");
            }
        }
    }
}
