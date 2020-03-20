using System;
using System.Linq;

namespace _339A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("+", Console.ReadLine()?.Split('+').OrderBy(n => n) ?? throw new InvalidOperationException()));
        }
    }
}
