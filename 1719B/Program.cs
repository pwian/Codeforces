using System;
using System.Collections.Generic;
using System.Linq;

namespace _1719B
{
    class Program
    {
        public static int GetInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public static int[] GetIntArray(char inSeparator = ' ')
        {
            return Console.ReadLine().Split(inSeparator).Select(int.Parse).ToArray();
        }

        static bool Check(int n, int k)
        {
            for (int j = 1; j < n; j += 2)
            {
                long ak = j + k;
                long bk = j + 1 + k;
                if (ak * (j + 1) % 4 != 0 && bk * j % 4 != 0)
                    return false;   
            }
            return true;
        }

        static void Main(string[] args)
        {
            var t = GetInt();
            for (int i = 0; i < t; i++)
            {
                var inputs = GetIntArray();
                var n = inputs[0];
                var k = inputs[1];
                if (k == 0)
                { 
                    Console.WriteLine("NO");
                    continue;
                }
                var result = Check(n, k);
                if (!result)
                {
                    Console.WriteLine("NO");
                    continue;
                }
                Console.WriteLine("YES");
                for (int j = 1; j < n; j += 2)
                {
                    long ak = j + k;
                    if (ak * (j + 1) % 4 == 0)
                        Console.WriteLine($"{j} {j + 1}");
                    else
                        Console.WriteLine($"{j + 1} {j}");
                }
            }
        }
    }
}
