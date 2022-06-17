using System;
using System.Collections.Generic;

namespace ListPractical
{
    class Program
    {
        static void Main(string[] args)
        {
            var AKLsuburb = new List<string>(); //suburb list
            AKLsuburb.Add("Papakura");
            AKLsuburb.Add("Takanini");
            AKLsuburb.Add("Manukau");
            AKLsuburb.Add("Botany");
            AKLsuburb.Add("Mangere");
            AKLsuburb.Add("Mt.Albert");
            AKLsuburb.Add("Albany");
            AKLsuburb.Add("Henderson");
            AKLsuburb.Add("Panmure");
            AKLsuburb.Add("Ellerslie");
            foreach (var suburb in AKLsuburb)   //print elements in suburb list
            {
                Console.WriteLine(suburb);
            }
            Console.WriteLine();
            var AKLpostcode = new List<int>();  //post code list
            AKLpostcode.Add(2113);
            AKLpostcode.Add(2112);
            AKLpostcode.Add(2104);
            AKLpostcode.Add(2010);
            AKLpostcode.Add(2153);
            AKLpostcode.Add(1025);
            AKLpostcode.Add(0632);
            AKLpostcode.Add(0612);
            AKLpostcode.Add(1072);
            AKLpostcode.Add(1051);
            foreach (var code in AKLpostcode)   //print elements in postcode list
            {
                Console.WriteLine(code);
            }
            Console.WriteLine();
            AKLsuburb.Insert(10, "Drury");  //addition of new suburb element  
            AKLpostcode.Insert(10, 2114);   //addition of new postcode element
            foreach (var suburb in AKLsuburb)
            {
                Console.WriteLine(suburb);  //print list
            }
            Console.WriteLine();
            foreach (var code in AKLpostcode)
            {
                Console.WriteLine(code);    //print list

            }
            Console.WriteLine();
            AKLsuburb.RemoveAt(0);  //removal of suburb element
            AKLpostcode.RemoveAt(0);  //removal of postcode element
            foreach (var suburb in AKLsuburb)
            {
                Console.WriteLine(suburb);  //print list
            }
            Console.WriteLine();
            foreach (var code in AKLpostcode)
            {
                Console.WriteLine(code);    //print list
            }
            Console.WriteLine();
            Console.WriteLine("Check if suburb List contains 'Henderson'");
            Console.WriteLine(AKLsuburb.Contains("Henderson")); //list contains "string"
            Console.WriteLine("Check if postcode list contains '0612'");
            Console.WriteLine(AKLpostcode.Contains(0612));  //List contains "int"
        }
    }
    class testing
    {
        static void TypeLine(string line)
        {
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                System.Threading.Thread.Sleep(150);
            }
            Console.WriteLine("Hello world");
        }
    }
}
