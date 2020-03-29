using System;
using System.Linq;

namespace _867A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var str = Console.ReadLine();
            var sum = Enumerable.Range(1, str.Length - 1).Select(index => str[index] - str[index - 1]).Sum();
            Console.WriteLine(sum < 0 ? "YES" : "NO");
        }
    }
}
