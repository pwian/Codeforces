using System;
using System.Linq;

namespace _1A
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
            long weight = mas[0] % mas[2] == 0 ? mas[0] / mas[2] : mas[0] / mas[2] + 1;
            var height = mas[1] % mas[2] == 0 ? mas[1] / mas[2] : mas[1] / mas[2] + 1;
            Console.WriteLine(weight * height);
        }
    }
}
