using System;

namespace _711A
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] str = new string[n];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }

            bool flag = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i][0] == 'O' && str[i][1] == 'O')
                {
                    flag = true;
                    string place = "++|";
                    for (int j = 3; j < 5; j++)
                    {
                        place += str[i][j];
                    }
                    str[i] = place;
                    break;
                }
                else if (str[i][3] == 'O' && str[i][4] == 'O')
                {
                    flag = true;
                    string place = "";
                    for (int j = 0; j < 3; j++)
                    {
                        place += str[i][j];
                    }
                    place += "++";
                    str[i] = place;
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine("YES");
                for (int i = 0; i < str.Length; i++)
                {
                    Console.WriteLine(str[i]);
                }
            }
            else
                Console.WriteLine("NO");
        }
    }
}
