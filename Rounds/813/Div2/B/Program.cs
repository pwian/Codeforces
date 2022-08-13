using System;
using System.Linq;

namespace B
{
    class Program
    {
        static int GetNumberInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        static long GetNumberLong()
        {
            return Convert.ToInt64(Console.ReadLine());
        }

        static int[] GetArrayInt()
        {
            string[] @string = Console.ReadLine().Split(' ');
            int[] array = new int[@string.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(@string[i]);
            }
            return array;
        }

        static long[] GetArrayLong()
        {
            string[] @string = Console.ReadLine().Split(' ');
            long[] array = new long[@string.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt64(@string[i]);
            }
            return array;
        }

        static void MinPArray(int m, int[] oddArray, int[] evenArray)
        {
            var array = m % 2 == 0 ? evenArray : oddArray;
            var seq = array.Take(m);
            var strSeq = String.Join(' ', seq);
            Console.WriteLine(strSeq);
        }

        static int[] GetOddSeq(int n = 100000 - 1)
        {
            int[] seq = new int[n];
            seq[0] = 1;
            for (int i = 1; i < n; i += 2)
            {
                seq[i] = i + 2;
                seq[i + 1] = i + 1;
            }
            return seq;
        }
        static int[] GetEvenSeq(int n = 100000)
        {
            int[] seq = new int[n];
            for (int i = 0; i < n; i += 2)
            {
                seq[i] = i + 2;
                seq[i + 1] = i + 1;
            }
            return seq;
        }

        static void Main(string[] args)
        {
            var t = GetNumberInt();
            var oddArray = GetOddSeq();
            var evenArray = GetEvenSeq();
            for (int i = 0; i < t; i++)
            {
                var n = GetNumberInt();
                MinPArray(n, oddArray, evenArray);
            }
        }
    }
}