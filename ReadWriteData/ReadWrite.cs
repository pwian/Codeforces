using System;
using System.Linq;

namespace ReadWriteData
{
    public static class ReadWrite
    {
        public static int[] GetIntArray(char inSeparator = ' ')
        {
            return Console.ReadLine().Split(inSeparator).Select(int.Parse).ToArray();
        }
    }
}
