using System;
using System.Linq;

namespace _1719С
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

        static int CountWin(int[] aArray, int numberPerson, int countRound)
        {
            if (numberPerson - 1 > countRound)
            {
                return 0;
            }

            int strongPerson = aArray[numberPerson - 1];
            var n = aArray.Length;
            for (int i = 0; i < numberPerson; i++)
            {
                if (aArray[i] > strongPerson)
                    return 0;
            }

            int win = numberPerson > 1 ? 1 : 0;
            int restCountRound = countRound - numberPerson + 1;
            for (int i = numberPerson; i < n; i++)
            {
                if (restCountRound < 1)
                {
                    break;
                }
                if (aArray[i] > strongPerson)
                {
                    restCountRound = 0;
                    break;
                }
                win++;
                restCountRound--;
            }

            return win + restCountRound;
        } 

        static void Main(string[] args)
        {
            var t = GetInt();
            for (int i = 0; i < t; i++)
            {
                var inputs = GetIntArray();
                var n = inputs[0];
                var q = inputs[1];
                var aArray = GetIntArray();
                for (int j = 0; j < q; j++)
                {
                    var inputs2 = GetIntArray();
                    var qi = inputs2[0];
                    var qk = inputs2[1];
                    Console.WriteLine(CountWin(aArray, qi, qk));
                }
            }
        }
    }
}
