using System;
using System.IO;

namespace FileHandling_Exist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\DJBur\Downloads\Darren.txt";
            if (File.Exists(filePath))
            {
                Console.WriteLine("File does exist");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }
    }
}
