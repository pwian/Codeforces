using System;

namespace _727A
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

        static bool PossibleAtoB(long[] array, int currentIndex, long b)
        {
            if (array[currentIndex] > b)
                return false;
            if (array[currentIndex] == b)
                return true;
            array[currentIndex + 1] = 2 * array[currentIndex];
            bool flag = PossibleAtoB(array, currentIndex + 1, b);
            if (!flag)
            {
                array[currentIndex + 1] = 10 * array[currentIndex] + 1;
                flag = PossibleAtoB(array, currentIndex + 1, b);
            }
            return flag;
        }
        static int GetLengthArray(long[] array, long b)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                count++;
                if (array[i] >= b)
                    break;
            }
            return count;
        }
        static void Main(string[] args)
        {
            long[] array = GetArrayLong();
            long a = array[0], b = array[1];
            int count = 0;
            array = new long[40];
            array[0] = a;
            bool flag = PossibleAtoB(array, 0, b);
            if (flag)
            {
                Console.WriteLine("YES");
                count = GetLengthArray(array, b);
                Console.WriteLine(count);
                for (int i = 0; i < count; i++)
                {
                    Console.Write("{0} ", array[i]);
                }
            }
            else
                Console.WriteLine("NO");
        }
    }
}
