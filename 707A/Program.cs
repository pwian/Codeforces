using System;

namespace _707A
{
    class Program
    {
        static int[] GetNumber(string[] str)
        {
            int[] array = new int[str.Length];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(str[i]);
            }
            return array;
        }

        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int[] array = GetNumber(str);
            bool flag = false;                              //black - white photo

            for (int i = 0; i < array[0]; i++)
            {
                string line = Console.ReadLine();
                if (line.Contains("C") || line.Contains("M") || line.Contains("Y"))
                {
                    flag = true;
                    break;
                }

            }

            if (flag)
                Console.WriteLine("#Color");
            else
                Console.WriteLine("#Black&White");

        }
    }
}
