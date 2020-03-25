using System;

namespace _996A
{
    class Program
    {
        public static long GetLong()
        {
            return long.Parse(Console.ReadLine());
        }

        public static long GetCountPerBill(long n, params int[]  bills)
        {
            long count = 0;
            foreach (var bill in bills)
            {
                count += n / bill;
                n = n % bill;
            }

            return count;
        }

        static void Main(string[] args)
        {
            var n = GetLong();
            //1 , 5, 10, 20, 100 - bills
            Console.WriteLine(GetCountPerBill(n, 100, 20, 10, 5, 1));
        }
    }
}
