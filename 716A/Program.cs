using System;
using System.Linq;

namespace _716A
{
    class Program
    {
        public static int[] GetIntArray(char inSeparator = ' ')
        {
            return Console.ReadLine().Split(inSeparator).Select(int.Parse).ToArray();
        }

        static void Main(string[] args)
        {
            int[] array = GetIntArray();
            int n = array[0], c = array[1];
            array = GetIntArray();

            var lastClearIndex = Enumerable.Range(1, n - 1).FirstOrDefault(index => array[n - index] - array[n - index - 1] > c);
            if (lastClearIndex == 0)
            {
                lastClearIndex = n;
            }
            Console.WriteLine(lastClearIndex);
        }
    }
}
