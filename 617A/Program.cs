using System;

namespace _617A
{
    class Program
    {
        public static int GetInt()
        {
            return int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            var x = GetInt();
            Console.WriteLine(x % 5 == 0 ? x / 5 : x / 5 + 1);
        }
    }
}
