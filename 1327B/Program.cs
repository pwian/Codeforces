using System;
using System.Collections.Generic;
using System.Linq;

namespace _1327B
{
    class Program
    {
        public static int GetInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public static HashSet<int> GetIntExceptFirstArray(char inSeparator = ' ')
        {
            var str = Console.ReadLine();
            if (str.Length == 1)
            {
                return new HashSet<int>();
            }
            var index = str.IndexOf(' ');
            str = str.Substring(index + 1);
            var mas = str.Split(inSeparator).Select(int.Parse);
            return new HashSet<int>(mas);
        }

        static void Main(string[] args)
        {
            var t = GetInt();
            for (int i = 0; i < t; i++)
            {
                var n = GetInt();
                var chosenKingdom = new HashSet<int>();
                int? freePrinces = null;
                for (int j = 1; j <= n; j++)
                {
                    var data = GetIntExceptFirstArray();
                    var possible = data.FirstOrDefault(king => !chosenKingdom.Contains(king));
                    if (possible != 0)
                    {
                        chosenKingdom.Add(possible);
                    }
                    else if (!freePrinces.HasValue)
                    {
                        freePrinces = j;
                    }
                }

                if (chosenKingdom.Count < n)
                {
                    var possible = Enumerable.Range(1, n).First(king => !chosenKingdom.Contains(king));
                    Console.WriteLine("IMPROVE");
                    Console.WriteLine($"{freePrinces} {possible}");
                }
                else
                {
                    Console.WriteLine("OPTIMAL");
                }
            }
        }
    }
}
