using System;
using System.Linq;

namespace _1220A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var str = Console.ReadLine();
            var countOne = str.Count(c => c == 'n');
            var countZero = str.Count(c => c == 'r');
            Console.WriteLine(string.Join(" ", Enumerable.Repeat(1, countOne).Concat(Enumerable.Repeat(0, countZero))));
        }
    }
}
