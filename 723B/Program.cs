using System;

namespace _723B
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

        static int CountWordIn(string text, ref int maxLengthWordOut)
        {
            int countWordIn = 0, lengthWordOut = 0;
            int i = 0;
            while (i < text.Length)
            {
                while (i < text.Length && text[i] == '_') i++;
                while (i < text.Length && text[i] != '(')
                {
                    lengthWordOut = 0;
                    while (i < text.Length && text[i] == '_') i++;
                    while (i < text.Length && text[i] != '(' && text[i] != '_')
                    {
                        lengthWordOut++; //Console.WriteLine("{0} {1}", i, lengthWordOut);
                        i++;
                    }
                    if (maxLengthWordOut < lengthWordOut)
                        maxLengthWordOut = lengthWordOut;
                    while (i < text.Length && text[i] == '_') i++;
                }

                if (i < text.Length && text[i] == '(') i++;
                while (i < text.Length && text[i] != ')')
                {
                    while (i < text.Length && text[i] == '_') i++;
                    if (i < text.Length && text[i] != ')')
                        countWordIn++;
                    while (i < text.Length && text[i] != ')' && text[i] != '_')
                    {
                        i++;
                    }
                }
                if (i < text.Length && text[i] == ')') i++;
            }
            return countWordIn;
        }
        static void Main(string[] args)
        {
            int n = GetNumberInt();
            string text = Console.ReadLine();
            int max = 0;
            int count = CountWordIn(text, ref max);
            Console.WriteLine("{0} {1}", max, count);
            //string[] words = Console.ReadLine().Split(' ', '_', '(', ')');
        }
    }
}
