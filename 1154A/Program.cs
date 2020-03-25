using System;
using System.Linq;

namespace _1154A
{
    public static class ReadWriteGeneric
    {
        public static T GetInputs<T>(this string inInput, char inSeparator = ' ')
        {
            if (!typeof(T).IsArray)
            {
                return (T)Convert.ChangeType(inInput, typeof(T));
            }

            var inputList = inInput.Split(inSeparator);
            var elementType = typeof(T).GetElementType();

            var array = Array.CreateInstance(elementType, inputList.Length);
            for (var i = 0; i < array.Length; i++)
            {
                array.SetValue(Convert.ChangeType(inputList[i], elementType), i);
            }


            return (T)(object)array;
        }
    }

    static class Program
    {
        static void Main(string[] args)
        {
            var mas = Console.ReadLine().GetInputs<int[]>().OrderBy(n => n).ToArray();
            int x1 = mas[0], x2 = mas[1], x3 = mas[2];
            var a = (x2 + x1 - x3) / 2;
            var b = (x3 + x1 - x2) / 2;
            var c = (x3 + x2 - x1) / 2;
            Console.WriteLine($"{a} {b} {c}");
        }
    }
}
