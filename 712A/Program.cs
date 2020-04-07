using System;

namespace _712A
{
    class Program
    {
        static long[] GetDataString()
        {
            string[] str = Console.ReadLine().Split(' ');
            long[] array = new long[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                array[i] = Convert.ToInt32(str[i]);
            }
            return array;
        }

        static long[] NewArray(long[] array)
        {
            long[] b = new long[array.Length];
            b[b.Length - 1] = array[array.Length - 1];
            long sum = b[b.Length - 1];
            for (int i = b.Length - 2; i >= 0; i--)
            {
                b[i] = array[i] + sum;
                sum = b[i] - sum;
            }
            return b;
        }

        static void Main(string[] args)
        {
            long[] nArray = GetDataString();
            long n = nArray[0];
            long[] array = GetDataString();
            long[] b = NewArray(array);
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write("{0} ", b[i]);
            }
        }
    }
}
