using System;
using System.Collections.Generic;

namespace _725C
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

        static int IndexTwoChar(string str)
        {
            Dictionary<char, int> line = new Dictionary<char, int>();
            int index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (line.ContainsKey(str[i]))
                {
                    index = i;
                    break;
                }
                else
                    line.Add(str[i], i);
            }
            return index;
        }

        static int IndexOneChar(string str, int index)
        {
            int number = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == str[index])
                {
                    number = i;
                    break;
                }
            }
            return number;
        }

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int indexTwoChar = IndexTwoChar(str);
            int indexOneChar = IndexOneChar(str, indexTwoChar);
            if (indexTwoChar - indexOneChar == 1)
                Console.WriteLine("Impossible");
            else
            {
                string line1 = "";
                string line2 = "";
                string buf = "";
                int between = indexTwoChar - 1 - indexOneChar; //Console.WriteLine(between);
                line1 += str[indexOneChar];
                for (int i = indexOneChar + 1; i <= indexOneChar + between / 2; i++)
                {
                    line1 += str[i];
                }
                for (int i = indexOneChar + between / 2 + 1; i < indexTwoChar; i++)
                {
                    line2 = str[i] + line2;
                }

                //Console.WriteLine(line1);
                //Console.WriteLine(line2);

                for (int i = indexTwoChar + 1; i < str.Length; i++)
                {
                    if (line2.Length < 13)
                        line2 = str[i] + line2;
                    else
                        buf += str[i];
                }

                for (int i = 0; i < indexOneChar; i++)
                {
                    if (line2.Length < 13)
                        line2 = str[i] + line2;
                    else
                        buf += str[i];
                }
                line1 = buf + line1;

                Console.WriteLine(line1);
                Console.WriteLine(line2);
            }
        }
    }
}
