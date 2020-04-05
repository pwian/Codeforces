using System;

namespace _710B
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

        static long Path(int[] array, int index)
        {
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += Math.Abs(array[i] - array[index]);
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int countPoint = Convert.ToInt32(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            int[] points = GetNumber(str);
            Array.Sort(points);
            if (points.Length == 1)
                Console.WriteLine(points[0]);
            else
            {
                int middle = (points.Length - 1) / 2;
                long path1 = Path(points, middle);
                long path2 = Path(points, middle + 1);
                if (path1 <= path2)
                    Console.WriteLine(points[middle]);
                else
                    Console.WriteLine(points[middle + 1]);

            }
        }
    }
}
