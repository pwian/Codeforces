using System;

namespace _711B
{
    class Program
    {
        static void GetMatr(long[,] matr, out int k, out int m)
        {
            string[] str;
            k = 0;
            m = 0;

            for (int i = 0; i < matr.GetLength(0); i++)
            {
                str = Console.ReadLine().Split(' ');
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    matr[i, j] = Convert.ToInt64(str[j]);
                    if (matr[i, j] == 0)
                    {
                        k = i;
                        m = j;
                    }
                }
            }
        }

        static bool MagicSquare(long[,] matr, int k, int m, out long number)
        {
            int n = matr.GetLength(0);
            long sum = 0;
            if (k == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    sum += matr[1, i];
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    sum += matr[0, i];
                }
            }

            long buf = 0;
            for (int i = 0; i < n; i++)
            {
                buf += matr[k, i];
            }
            matr[k, m] = sum - buf;                                 //Вставили число
            number = matr[k, m];
            bool flag = matr[k, m] > 0;

            long buf1 = 0, buf2 = 0;
            for (int i = 0; i < n; i++)
            {
                buf1 += matr[i, i];
                buf2 += matr[i, n - i - 1];
            }
            flag = (flag && buf1 == sum && buf2 == sum);

            int p = 0;
            while (flag && p < n)
            {
                buf1 = 0; buf2 = 0;
                for (int j = 0; j < n; j++)
                {
                    buf1 += matr[p, j];
                    buf2 += matr[j, p];
                }
                flag = (buf1 == sum && buf2 == sum);
                p++;
            }
            return flag;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            long[,] matr = new long[n, n];
            int k, m;
            GetMatr(matr, out k, out m);
            if (n == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                long number;
                bool flag = MagicSquare(matr, k, m, out number);
                if (flag)
                    Console.WriteLine(number);
                else
                    Console.WriteLine("-1");
            }
        }
    }
}
