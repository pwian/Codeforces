using System;
using System.Linq;

namespace _1146A
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var countA = input.Count(symbol => symbol == 'a');
            Console.WriteLine(2 * countA > input.Length ? input.Length : 2 * countA - 1);
        }
    }
}
