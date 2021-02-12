using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(63, "Samet Vural");
            dictionary.Add(94, "Sezer Bozbıyık");
            dictionary.Add(95, "Celal Seyidov");

            

            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(123, "sezer");

            myDictionary.List();
            int sonuc = myDictionary.Count;
            Console.WriteLine(sonuc);
        }
    }
}
