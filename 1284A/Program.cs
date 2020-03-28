using System;

namespace _1284A
{
    class Program
    {
        public static int GetInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public static int AdditionalMatchCount(int n)
        {
            if (n == 2)
            {
                return 2;
            }

            if (n % 2 == 0)
            {
                return 0;
            }

            return 1;
        }

        static void Main(string[] args)
        {
            var q = GetInt();
            for (int i = 0; i < q; i++)
            {
                var n = GetInt();
                Console.WriteLine(AdditionalMatchCount(n));
            }
        }
    }
}
