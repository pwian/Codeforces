﻿using System;
using System.Linq;

namespace ReadWriteData
{
    public static class ReadWrite
    {
        public static int GetInt()
        {
            return int.Parse(Console.ReadLine());
        }

        public static long GetLong()
        {
            return long.Parse(Console.ReadLine());
        }

        public static int[] GetIntArray(char inSeparator = ' ')
        {
            return Console.ReadLine().Split(inSeparator).Select(int.Parse).ToArray();
        }        

        public static long[] GetLongArray(char inSeparator = ' ')
        {
            return Console.ReadLine().Split(inSeparator).Select(long.Parse).ToArray();
        }
    }
}
