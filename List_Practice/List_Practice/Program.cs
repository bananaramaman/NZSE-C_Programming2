using System;
using System.Collections.Generic;

namespace List_Practice
{
    class Program
    {
        public static void Main()
        {
            var assaultRifle = new List<string>();  //string list 
            assaultRifle.Add("AK-47");
            assaultRifle.Add("AR-15");
            assaultRifle.Add("M4-A2");
            assaultRifle.Add("L1A1 SLR");
            assaultRifle.Add("FN-FAL");
            assaultRifle.Add("M16-A1");
            assaultRifle.Add("AKM");
            assaultRifle.Add("Valmet RK-62");
            assaultRifle.Add("Daewoo K2");
            assaultRifle.Add("QBZ-95");
            assaultRifle.Add("SKS");
            assaultRifle.Add("H&K G3");
            assaultRifle.Add(null);
            Console.WriteLine("Number of Rifles:" + assaultRifle.Count);    //prints total number of list elements including null variable
            Console.WriteLine();
            string[] input = { "H&K G36", "STG-44", "SVT-40" }; //creating new input string 
            assaultRifle.InsertRange(3, input); //adding new string to existing list

            foreach (var rifle in assaultRifle) //printing total elements in list, including newly input string variables 
            {
                Console.WriteLine(rifle);
            }
            Console.WriteLine();

            var calibre = new List<double>();   //double list using add method
            calibre.Add(7.62);
            calibre.Add(5.56);
            calibre.Add(5.56);
            calibre.Add(.308);
            calibre.Add(7.62);
            calibre.Add(.223);
            calibre.Add(5.45);
            calibre.Add(7.62);
            calibre.Add(5.56);
            calibre.Add(5.8);
            calibre.Add(7.62);
            calibre.Add(7.62);
            Console.WriteLine("Firearm calibers:" + calibre.Count);     //print total list elements
            Console.WriteLine();
            calibre.Insert(12, .338);    //inserts value 0.338 at list element position 0
            foreach (var unit in calibre)
            {
                Console.WriteLine(unit);    //prints the list elements including the recently added variable
            }
            Console.WriteLine();

            var countryofOrigin = new List<string>()    //string list, w/out add method
            {"Soviet Union", "USA", "USA", "Great Birtan","Belgium","USA","Soviet Union","Finland","South Korea","PRC","Soviet Union","Germany"};

            countryofOrigin.RemoveRange(1,2);   //remove range of elements 
            countryofOrigin.Remove("USA");      //remove individual element "USA"

            foreach (var country in countryofOrigin)    //printing each var in list
            {
                Console.WriteLine(country);
            }
            Console.WriteLine();
            Console.WriteLine("Country of origin:" + countryofOrigin.Count);
            Console.WriteLine();

            Console.WriteLine(assaultRifle.Contains("AK-47"));
            Console.WriteLine(calibre.Contains(7.62));
            Console.WriteLine(countryofOrigin.Contains("USA"));
        }
    }
}
