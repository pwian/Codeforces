using System;

namespace _723A
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
            Array.Sort(array);
            //double mid = (array[0] + array[1] +array[2] ) / 3.0;
            //int min = (int)(Math.Abs(array[0] - mid) + Math.Abs(array[1] - mid) + Math.Abs(array[2] - mid));
            int min = array[2] - array[1] + array[1] - array[0];
            Console.WriteLine(min);

        }
    }
}
