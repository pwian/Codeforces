using System;

namespace ReadWriteData
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
}
