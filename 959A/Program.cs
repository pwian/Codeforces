using System;

namespace _959A
{
    class Program
    {
        public static int GetInt()
        {
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetInt() % 2 == 0 ? "Mahmoud" : "Ehab");
        }
    }
}
