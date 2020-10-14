using System;

namespace _719A
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
        static void Main(string[] args)
        {
            int n = GetIntNumber();
            int[] a = GetArrayIntNumber();
            if (n == 1)
            {
                if (a[0] == 0)
                    Console.WriteLine("UP");
                else if (a[0] == 15)
                    Console.WriteLine("DOWN");
                else
                    Console.WriteLine("-1");
            }

            else if (a[n - 1] == 15)
                Console.WriteLine("DOWN");
            else if (a[n - 1] == 0)
                Console.WriteLine("UP");
            else if (a[n - 1] > a[n - 2])
                Console.WriteLine("UP");
            else
                Console.WriteLine("DOWN");
        }
    }
}
