using System;
using System.Collections.Generic;

namespace Palindrome
{
    public static class Extention
    {
        public static string Find(this string normal, List<char> chartoremove)
        {
            foreach (var c in chartoremove)
            {
                normal = normal.Replace(c.ToString(), string.Empty);
            }
            return normal;
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            string normal = "@ab#ba!!!";
            List<char> chartoremove = new List<char>() { '@', '#', '!' };

            normal = normal.Find(chartoremove);

            Console.WriteLine(normal);

            var array = new char[normal.Length];
            for (var i = normal.Length; i > 0; i--)
            {
                array[normal.Length - i] = normal[i - 1];
            }
            var reversed = new string(array);

            var Palindrome = false;
            if (normal.Contains(reversed))
            {
                Palindrome = true;
            }

            var kekka = Palindrome ? "Palindrome" : "Not Palindrome";
            Console.WriteLine(kekka);
        }
    }
}

