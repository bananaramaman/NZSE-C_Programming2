using System;

namespace ClassObjectPractice
{
    class Car
    {
        string model;
        string colour;
        int year;
        double engineSize;
        string transmission;


        static void Main(string[] args)
        {
            Car Holden = new Car();
            Holden.model = "VX Commodore";
            Holden.colour = "Red";
            Holden.year = 2001;
            Holden.engineSize = 5.7;
            Holden.transmission = "Manual";

            Car Ford = new Car();
            Ford.model = "AU Falcon";
            Ford.colour = "Blue";
            Ford.year = 2000;
            Ford.engineSize = 4.0;
            Ford.transmission = "Automatic";

            Console.WriteLine("-Make: Ford\n-model: {0}\n-colour: {1}\n-year: {2}\n-Engine size: {3}ltr\n-Transmission: {4}",Ford.model,Ford.colour,Ford.year,Ford.engineSize,Ford.transmission);
            Console.WriteLine();
            Console.WriteLine("-Make: Holden\n-model: {0}\n-colour: {1}\n-year: {2}\n-Engine size: {3}ltr\n-Transmission: {4}",Holden.model,Holden.colour,Holden.year,Holden.engineSize,Holden.transmission);

          
        }
    }
}
