using System;
using System.Collections.Generic;

namespace _721A
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

        static int GetNumberGroup(string str, List<int> list)
        {
            int countGroup = 0;
            int index = 0;
            while (index < str.Length)
            {
                while (index < str.Length && str[index] == 'W')
                    index++;
                int countB = 0;
                while (index < str.Length && str[index] == 'B')
                {
                    index++;
                    countB++;
                }
                if (countB != 0)
                {
                    countGroup++;
                    list.Add(countB);
                }

            }
            return countGroup;
        }
        static void Main(string[] args)
        {
            int n = GetNumberInt();
            string color = Console.ReadLine();
            List<int> list = new List<int>();
            int k = GetNumberGroup(color, list);
            Console.WriteLine(k);
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
