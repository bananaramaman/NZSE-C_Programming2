using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FileHandling_Copy_Delete
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\DJBur\Downloads\DarrenCopy.txt";   //source file path 

            string copypath = @"C:\Users\DJBur\Downloads\DarrenCopy2.txt";   //copy file path

            File.Copy(path, copypath);
            Console.WriteLine("File has been copied");
            Console.ReadKey();

            string delete = @"C:\Users\DJBur\Downloads\DarrenCopy.txt";   //delete file path

            File.Delete(delete);
            Console.WriteLine("Original has been deleted");
            Console.ReadKey();

            string create = @"C:\Users\DJBur\Downloads\Darren.txt";   //new custom file path

            File.WriteAllText(create, "Your lightsaber will make a fine addition to my collection");    //string to add to file
            Console.WriteLine("The new document has been created");
            Console.ReadKey();


        }
    }
}
