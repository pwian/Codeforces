using System;

namespace _714A
{
    class Program
    {
        static long[] GetData()
        {
            string[] str = Console.ReadLine().Split(new char[] { ' ' });
            long[] array = new long[str.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt64(str[i]);
            }
            return array;
        }

        static void Main(string[] args)
        {
            long[] array = GetData();

            long leftTime = Math.Max(array[0], array[2]);
            long rightTime = Math.Min(array[1], array[3]);

            long countTime = 0;
            if (rightTime >= leftTime)
            {
                countTime = rightTime - leftTime + 1;
                if (array[4] >= leftTime && array[4] <= rightTime)
                    countTime--;
            }
            Console.WriteLine(countTime);

        }
    }
}
