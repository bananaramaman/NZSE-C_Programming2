using System;
using System.Collections.Generic;

namespace FA1_ListProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            var Country = new List<string>();
            var Capital = new List<string>();
            Console.WriteLine("Please Input 10 Countries, with their capital cities");
            while (i < 10)
            {
                
                Console.WriteLine("\nCountry:");
                Country.Add(Console.ReadLine());
                Console.WriteLine("Capital:");
                Capital.Add(Console.ReadLine());
                i++;
            }
            Console.WriteLine();
            foreach (var cnt in Country)
            {
                Console.WriteLine(cnt);
            }
            Console.WriteLine();
            foreach (var cty in Capital)
            {
                Console.WriteLine(cty);
            }
            Console.WriteLine("Please select an option [1] = INSERT(), [2] = REMOVE(), [3] = CONTAINS()");
            int method = Convert.ToInt32(Console.ReadLine());
            if (method > 3 || method < 1)
            {
                Console.WriteLine("Incorrect selection. Please try again.");
                System.Environment.Exit(0);
            }
            switch (method)
            {
                case 1:
                    string[] Countryinput = { "Malawi", "Namibia", "Bulgaria", "Hungary", "Kuwait" };
                    Country.InsertRange(10, Countryinput);
                    string[] Capitalinput = { "Lilongwe", "Windhoek", "Sofia", "Budapest", "Kuwait City" };
                    Capital.InsertRange(10, Capitalinput);
                    Console.WriteLine();
                    foreach (var cnt in Country)
                    {
                        Console.WriteLine(cnt);
                    }
                    Console.WriteLine();
                    foreach (var cty in Capital)
                    {
                        Console.WriteLine(cty);
                    }
                    break;

                case 2:
                    Console.WriteLine("Please Input the Countries you wish to remove");
                    Country.Remove(Console.ReadLine());
                    Country.Remove(Console.ReadLine());
                    Country.Remove(Console.ReadLine());
                    Country.Remove(Console.ReadLine());
                    Country.Remove(Console.ReadLine());
                    Console.WriteLine("Please input the list position of the Cities you wish to remove");
                    Capital.RemoveAt(Convert.ToInt32(Console.ReadLine()));
                    Capital.RemoveAt(Convert.ToInt32(Console.ReadLine()));
                    Capital.RemoveAt(Convert.ToInt32(Console.ReadLine()));
                    Capital.RemoveAt(Convert.ToInt32(Console.ReadLine()));
                    Capital.RemoveAt(Convert.ToInt32(Console.ReadLine()));
                    
                    foreach (var cnt in Country)
                    {
                        Console.WriteLine(cnt);
                    }
                    Console.WriteLine();
                    foreach (var cty in Capital)
                    {
                        Console.WriteLine(cty);
                    }
                    break;

                case 3:
                    int x = 0;
                    while (x < 5)
                    {
                        Console.WriteLine("Search the list for a specific country");
                        Console.WriteLine(Country.Contains(Console.ReadLine()));
                        x++;
                    }
                    break;
            }
        }
    }
}
