using System;
using System.Linq;

namespace _708A
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var indexNonA = input
                .Select((c, i) => new { Symbol = c, Index = i })
                .Where(group => group.Symbol > 'a')
                .FirstOrDefault()
                ?.Index ?? input.Length - 1;
            var lastIndex = input.IndexOf('a', indexNonA + 1);
            if (lastIndex == -1)
            {
                lastIndex = input.Length;
            }

            var firstPart = input.Substring(0, indexNonA);
            var secondPart = string.Concat(input.Substring(indexNonA, lastIndex - indexNonA).Select(symbol => symbol == 'a' ? 'z' : (char)(symbol - 1)));
            var thirdPart = lastIndex >= input.Length
                ? string.Empty
                : input.Substring(lastIndex, input.Length - lastIndex);
            var result = string.Concat(firstPart, secondPart, thirdPart);
            Console.WriteLine(result);
        }
    }
}
