using System;

namespace _722B
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
            string[] line = Console.ReadLine().Split(' ');
            int[] array = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                array[i] = Convert.ToInt32(line[i]);
            }
            return array;
        }

        static long[] GetArrayLong()
        {
            string[] line = Console.ReadLine().Split(' ');
            long[] array = new long[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                array[i] = Convert.ToInt64(line[i]);
            }
            return array;
        }

        static int CountVower(string line)
        {
            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == 'a' || line[i] == 'e' || line[i] == 'o' || line[i] == 'i' || line[i] == 'y' || line[i] == 'u')
                    count++;
            }
            return count;
        }

        static bool Solve(string[] text, int[] p)
        {
            bool flag = true;
            for (int i = 0; i < text.Length; i++)
            {
                flag = p[i] == CountVower(text[i]);
                if (!flag)
                    break;
            }
            return flag;
        }
        static void Main(string[] args)
        {
            int n = GetNumberInt();
            int[] p = GetArrayInt();
            string[] text = new string[n];
            for (int i = 0; i < n; i++)
            {
                text[i] = Console.ReadLine();
            }
            if (Solve(text, p))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
