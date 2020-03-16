using System;

namespace _4A
{
    class Program
    {
        static int ReadInt()
        {
            return int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
        }

        static void Main(string[] args)
        {
            var w = ReadInt();
            var answer = w > 3 && (w - 2) % 2 == 0;
            Console.WriteLine(answer ? "YES" : "NO");
        }
    }
}
