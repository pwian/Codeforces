using System;
using System.Linq;

namespace A
{
    class Program
    {
        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static long GetNumberLong()
        {
            return Convert.ToInt64(Console.ReadLine());
        }

        static int[] GetArrayInt()
        {
            string[] @string = Console.ReadLine().Split(' ');
            int[] array = new int[@string.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(@string[i]);
            }
            return array;
        }

        static long[] GetArrayLong()
        {
            string[] @string = Console.ReadLine().Split(' ');
            long[] array = new long[@string.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt64(@string[i]);
            }
            return array;
        }

        static void Main(string[] args)
        {
            var t = GetNumberInt();
            for (int i = 0; i < t; i++)
            {
                var mas = GetArrayInt();
                var n = mas[0];
                var k = mas[1];
                var pMas = GetArrayInt();
                var firstMas = pMas.Take(k).ToArray();
                var count = firstMas.Count(element => element > k);
                Console.WriteLine(count);
            }
        }
    }
}