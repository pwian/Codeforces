using System;

namespace _722A
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

        static string NewTime(int hour, int minut)
        {
            string time = "";
            if (hour < 10)
                time += "0";
            time += Convert.ToString(hour) + ":";
            if (minut < 10)
                time += "0";
            time += Convert.ToString(minut);
            return time;

        }
        static void Main(string[] args)
        {
            int n = GetNumberInt();
            string[] time = Console.ReadLine().Split(':');
            int hour = Convert.ToInt32(time[0]);
            int minut = Convert.ToInt32(time[1]);
            if (minut >= 60)
                minut = 10 + minut % 10;

            //Console.WriteLine("{0}:{1}", hour, minut);
            if (n == 12)
            {
                if (hour > 12)
                    hour = hour % 10;
                if (hour == 0)
                    hour = 10;
            }
            else
            {
                if (hour > 23)
                    hour = hour % 10;
            }
            Console.WriteLine(NewTime(hour, minut));
        }
    }
}
