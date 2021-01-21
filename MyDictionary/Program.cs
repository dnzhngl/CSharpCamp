using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> md = new MyDictionary<int, string>();
            md.Add(1, "Ayşe");
            md.Add(2, "Veli");
            md.Add(3, "Ahmet");

            Console.WriteLine(md.Count);

            var keys = md.Keys;
            var values = md.Values;
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " : " + values[i]);
            }

        }
    }
}
