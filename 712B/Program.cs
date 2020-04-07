using System;

namespace _712B
{
    class Program
    {
        static int[] GetCount(string str)
        {
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            for (int i = 0; i < str.Length; i++)
            {
                switch (str[i])
                {
                    case 'L':
                        sum1++;
                        break;
                    case 'R':
                        sum2++;
                        break;
                    case 'U':
                        sum3++;
                        break;
                    case 'D':
                        sum4++;
                        break;
                }
            }
            int[] array = { sum1, sum2, sum3, sum4 };
            return array;
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int[] array = GetCount(str);
            int count = array[0] + array[1] + array[2] + array[3];
            if (count % 2 != 0 || str.Length == 1)
            {
                Console.WriteLine("-1");
            }
            else
            {
                count = Math.Abs(array[0] - array[1]) / 2 + Math.Abs(array[2] - array[3]) / 2;
                if (Math.Abs(array[0] - array[1]) % 2 != 0)
                    count++;
                Console.WriteLine(count);
            }
        }
    }
}
