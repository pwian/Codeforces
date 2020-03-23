using System;
using System.Linq;

namespace _705A
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var talks = Enumerable.Range(1, n).Select(index => index % 2 == 0 ? "I love" : "I hate");
            Console.WriteLine(string.Join(" that ", talks) + " it");
        }
    }
}
