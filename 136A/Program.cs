using System;
using System.Linq;
using System.Collections.Generic;

namespace _136A
{
    class Program
    {
        public static int GetInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public static Dictionary<int, int> GetDictionary(char inSeparator = ' ')
        {

            return Console.ReadLine()
                .Split(inSeparator)
                .Select((s, i) => new { Num = int.Parse(s), Index = i + 1})
                .ToDictionary(n => n.Num, n => n.Index);
        }

        static void Main(string[] args)
        {
            var n = GetInt();
            var dict = GetDictionary();
            var answer = Enumerable.Range(1, n).Select(i => dict[i]);
            Console.WriteLine(string.Join(" ", answer));
        }
    }
}
