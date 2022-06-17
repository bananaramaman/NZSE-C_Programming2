using System;
using System.Text;
using System.Linq;
using System.IO;

namespace FileHandling_ReadAllText
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\DJBur\Downloads\Darren.txt";   //declare file path to .txt file

            string lines;   //declare lines as variable
            lines = File.ReadAllText(path); //lines is part of the .txt file
            Console.WriteLine(lines);   //print all lines in .txt document
            
        }
    }
}
