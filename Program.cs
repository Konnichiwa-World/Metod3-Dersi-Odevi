using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] dizi = "Patika".ConvertToChars();

            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }

    public static class Extensions
    {
        public static char[] ConvertToChars(this string text)
        {
            char[] chars = new char[text.Length];
            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = text[i];
            }
            return chars;
        }
    }
}