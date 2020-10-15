using System;

namespace _721B
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
            int[] array = GetArrayInt();
            int n = array[0], k = array[1];
            array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = Console.ReadLine().Length;
            }
            int countPasswordNumber = Console.ReadLine().Length;
            Array.Sort(array);
            int index = 0;
            while (array[index] < countPasswordNumber)
                index++;
            int min = (5 * ((index) / k)) + index + 1;
            while (index < array.Length && array[index] == countPasswordNumber)
                index++;
            //if (index == array.Length)
            index--;
            int max = (5 * ((index) / k)) + index + 1;
            Console.WriteLine("{0} {1}", min, max);
        }
    }
}
