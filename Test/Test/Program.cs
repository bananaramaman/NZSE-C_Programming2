using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            var array = list.ToArray();

            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine(array[i]);
                i++;
            }
        }
    }
}
