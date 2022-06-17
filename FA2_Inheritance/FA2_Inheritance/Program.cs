using System;
using System.Collections.Generic;
namespace FA2_Inheritance
{
    class Program
    {
        public class Car //parent class
        {
            public void brand()
            {
                Console.Write("The car brand is - ");
            }
            public void Type()
            {
                Console.Write("The vehicle type is - ");
            }
            public void Colour()
            {
                Console.Write("The vehicle colour is - ");
            }
            public void Year()
            {
                Console.Write("Year of manufacture - ");
            }
        }
        public class Vento : Car
        {
            public void VentoInfo()
            {
                brand();
                Console.WriteLine("Volkswagen");
                Type();
                Console.WriteLine("Sedan");
                Colour();
                Console.WriteLine("Red");
                Year();
                Console.WriteLine(1996);
            }
        }
        public class Civic : Car
        {
            public void CivicInfo()
            {
                brand();
                Console.WriteLine("Honda");
                Type();
                Console.WriteLine("Hatchback");
                Colour();
                Console.WriteLine("White");
                Year();
                Console.WriteLine(1993);
            }
        }
        public class Corolla : Car
        {
            public void CorollaInfo()
            {
                brand();
                Console.WriteLine("Toyota");
                Type();
                Console.WriteLine("sedan");
                Colour();
                Console.WriteLine("Green");
                Year();
                Console.WriteLine(1991);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a make a selection\n[1] = Vento\n[2] = Civic\n[3] = Corolla");
            int vehicle = Convert.ToInt32(Console.ReadLine());
            if (vehicle > 3 || vehicle < 1)
            {
                Console.WriteLine("Incorrect selection, please rethink your life");
                System.Environment.Exit(0);
            }
            Vento v = new Vento();
            Civic c = new Civic();
            Corolla C = new Corolla();

            switch (vehicle)
            {
                case 1:
                    v.VentoInfo();
                    break;
                case 2:
                    c.CivicInfo();
                    break;
                case 3:
                    C.CorollaInfo();
                    break;
            }
        }
    }
}
