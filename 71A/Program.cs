using System;

namespace _71A
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            for (int i = 0; i < n; i++)
            {
                var str = Console.ReadLine();
                if (str != null)
                {
                    Console.WriteLine(str.Length <= 10 ? str : $"{str[0]}{str.Length - 2}{str[str.Length - 1]}");
                }
            }
        }
    }
}
