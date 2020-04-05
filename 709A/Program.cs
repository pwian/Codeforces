using System;

namespace _709A
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
            int b = array[1], d = array[2];
            str = Console.ReadLine().Split(' ');
            int[] size = GetNumber(str);

            int count = 0, currentSize = 0;
            for (int i = 0; i < size.Length;)
            {
                while (i < size.Length && currentSize <= d)
                {
                    if (size[i] <= b)
                        currentSize += size[i];
                    i++;
                }
                if (currentSize > d)
                {
                    count++;
                    currentSize = 0;
                }
            }
            Console.WriteLine(count);
        }
    }
}
