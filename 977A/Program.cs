using System;
using System.Linq;

namespace _977A
{
    class Program
    {
        static int[] ReadArray()
        {
            return Console.ReadLine()?.Split().Select(int.Parse).ToArray();
        }

        static void Main(string[] args)
        {
            var mas = ReadArray();
            int n = mas[0], k = mas[1];

            while (n > 1 && k-- > 0)
            {
                n = n % 10 == 0 ? n / 10 : n - 1;
            }

            Console.WriteLine(n);
        }
    }
}
