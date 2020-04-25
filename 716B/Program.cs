using System;

namespace _716B
{
    class Program
    {
        static bool PossibleGoodWord(string str, int k, int[] array)
        {
            bool flag = true;
            for (int j = 0; j < array.Length; j++)
            {
                array[j] = 0;
            }

            int i = 0, index;
            while (i < 26 && (k + i) < str.Length)
            {
                index = str[k + i] - 'A';

                if (index >= 0)
                {
                    array[index]++;
                    if (array[index] > 1)
                    {
                        flag = false;
                        break;
                    }
                }
                i++;
            }
            return flag;
        }

        static char NewSymbol(int[] array)
        {
            char c = 'A';
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    c = (char)(i + 'A');
                    array[i] = 1;
                    break;
                }
            }
            return c;
        }

        static string NewString(string old, int k, int[] array)
        {
            string goodString = "";
            for (int i = 0; i < k; i++)
            {
                if (old[i] != '?')
                    goodString += old[i];
                else
                    goodString += 'A';
            }

            for (int i = 0; i < 26; i++)
            {
                if (old[k + i] >= 'A' && old[k + i] <= 'Z')
                    goodString += old[k + i];
                else
                    goodString += NewSymbol(array);
            }

            for (int i = k + 26; i < old.Length; i++)
            {
                if (old[i] != '?')
                    goodString += old[i];
                else
                    goodString += 'A';
            }
            return goodString;
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int[] array = new int[26];
            bool flag = false;
            string answer = "-1";
            for (int i = 0; i <= (s.Length - 26); i++)
            {
                if (PossibleGoodWord(s, i, array))
                {
                    answer = NewString(s, i, array);
                    flag = true;
                    break;
                }
            }
            Console.WriteLine(answer);
        }
    }
}
