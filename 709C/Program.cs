using System;

namespace _709C
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            char[] line = new char[str.Length];
            int i = 0;
            //Console.WriteLine("str.length = {0}", str.Length);
            while (i < str.Length)
            {
                while (i < str.Length && str[i] == 'a')                     //Пропускаем a
                {
                    line[i] = str[i];
                    // Console.WriteLine("{0}, line = {1}", str[i], line[i]);
                    i++;
                }
                if (i == str.Length)
                {
                    line[i - 1] = 'z';
                    // break;
                }

                while (i < str.Length && str[i] != 'a')
                {
                    line[i] = (char)((int)str[i] - 1);
                    i++;
                }

                while (i < str.Length)
                {
                    line[i] = str[i];
                    i++;
                }
            }

            for (int j = 0; j < line.Length; j++)
            {
                Console.Write(line[j]);
            }

        }
    }
}
