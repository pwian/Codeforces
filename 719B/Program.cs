using System;

namespace _719B
{
    class Program
    {
        static int GetIntNumber()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static long GetLongNumber()
        {
            return Convert.ToInt64(Console.ReadLine());
        }

        static int[] GetArrayIntNumber()
        {
            string[] str = Console.ReadLine().Split(' ');
            int[] array = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                array[i] = Convert.ToInt32(str[i]);
            }
            return array;
        }

        static int CountChange(string str)
        {
            int countR1 = 0, countB1 = 0;
            int countR2 = 0, countB2 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (i % 2 == 0 && str[i] == 'b')
                    countB1++;
                else if (i % 2 == 1 && str[i] == 'r')
                    countR1++;
                if (i % 2 == 0 && str[i] == 'r')
                    countR2++;
                else if (i % 2 == 1 && str[i] == 'b')
                    countB2++;
            }
            int count1 = Math.Max(countR1, countB1);
            int count2 = Math.Max(countR2, countB2);
            return Math.Min(count1, count2);
        }
        static void Main(string[] args)
        {
            int n = GetIntNumber();
            string str = Console.ReadLine();
            if (n == 1)
                Console.WriteLine("0");
            else
                Console.WriteLine(CountChange(str));
        }
    }
}
