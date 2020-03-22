using System;
using System.Linq;

namespace _791A
{
    class Program
    {
        public static int[] GetIntArray(char inSeparator = ' ')
        {
            return Console.ReadLine().Split(inSeparator).Select(int.Parse).ToArray();
        }

        static void Main(string[] args)
        {
            var inputData = GetIntArray();
            int a = inputData[0], b = inputData[1];
            //a*3^x > b*2^x
            //x > log[1.5](b/a)
            var years = Math.Truncate(Math.Log(b / (double) a, 1.5)) + 1;
            Console.WriteLine(years);
        }
    }
}
