using System;

namespace _935A
{
    class Program
    {
        public static int GetInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public static int GetCountCase(int n)
        {
            var count = 1;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    count++;
                }
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetCountCase(GetInt()));
        }
    }
}
