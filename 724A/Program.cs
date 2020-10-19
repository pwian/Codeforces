using System;
using System.Collections.Generic;

namespace _724A
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

            //«monday» , «tuesday» ), «wednesday» 
            //, «thursday» , «friday» , «saturday» , «sunday» .
            Dictionary<string, int> days = new Dictionary<string, int>();
            days["monday"] = 1;
            days["tuesday"] = 2;
            days["wednesday"] = 3;
            days["thursday"] = 4;
            days["friday"] = 5;
            days["saturday"] = 6;
            days["sunday"] = 7;

            string day1 = Console.ReadLine();
            string day2 = Console.ReadLine();

            int d1 = days[day1];
            int d2 = days[day2];
            int subDays = d1 <= d2 ? d2 - d1 : 7 - d1 + d2;
            if (subDays == 0 || subDays == 2 || subDays == 3)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

        }
    }
}
