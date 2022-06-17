using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FileHandling_FileStreamCreate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\DJBur\Downloads\Sample.txt";
            FileStream fs = new FileStream(path, FileMode.Create);
            fs.Close();

            string path2 = @"C:\Users\DJBur\Downloads\Sample2.txt";
            using (StreamWriter sw = new StreamWriter(path2))
            {
                sw.WriteLine("Hello World");
                sw.WriteLine("Herp Derps");
                Console.ReadKey();
            }

        }
    }
}
