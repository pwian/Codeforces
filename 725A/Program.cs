using System;

namespace _725A
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
            int n = GetNumberInt();
            string str = Console.ReadLine();
            int count = 0;
            int i = 0;
            while (i < str.Length && str[i] == '<')
            {
                i++;
                count++;
            }
            int j = str.Length - 1;
            while (j >= i && str[j] == '>')
            {
                j--;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
