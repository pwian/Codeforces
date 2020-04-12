using System;
using System.Linq;

namespace _1284A
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

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var ns = Console.ReadLine().GetInputs<string[]>();
            var ms = Console.ReadLine().GetInputs<string[]>();
            var n = ns.Length;
            var m = ms.Length;
            var q = Console.ReadLine().GetInputs<int>();
            for (int i = 0; i < q; i++)
            {
                var y = Console.ReadLine().GetInputs<int>();
                Console.WriteLine($"{ns[(y - 1) % n]}{ms[(y - 1) % m]}");
            }
        }
    }
}
