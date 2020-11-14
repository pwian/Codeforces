using System;

namespace _725B
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
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char place2 = str[str.Length - 1];
            str = str.Remove(str.Length - 1); //Console.WriteLine(str);
            ulong place1 = Convert.ToUInt64(str);
            ulong countRow = (place1 - 1) / 4;                    //Количество полных прошедших рядов
            place1 = (place1 % 4);
            if (place1 == 0)
                place1 = 4;
            ulong time = countRow * 16;
            switch (place2)
            {
                case 'f':
                    time += 1;
                    break;
                case 'e':
                    time += 2;
                    break;
                case 'd':
                    time += 3;
                    break;
                case 'a':
                    time += 4;
                    break;
                case 'b':
                    time += 5;
                    break;
                case 'c':
                    time += 6;
                    break;
            }
            if (place1 == 2 || place1 == 4)
                time += 7;
            Console.WriteLine(time);
        }
    }
}
