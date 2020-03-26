using System;
using System.Linq;

namespace _1097A
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
            var firstCard = Console.ReadLine();
            var hand = Console.ReadLine().GetInputs<string[]>();
            Console.WriteLine(hand.Any(card => card[0] == firstCard[0] || card[1] == firstCard[1]) ? "YES" : "NO");
        }
    }
}
