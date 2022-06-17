using System;

namespace AreaCalculator_FridayTask
{
    public class Shape  //base class
    {
        public void formula1()  //parent 1 method
        {
            Console.WriteLine("Please Input width (in milimeters):");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Input Length (in milimeters):");
            double height = Convert.ToDouble(Console.ReadLine());
            double result = width * height;
            Console.WriteLine("The total area of your described shape is: \n{0}mm", result);
        }
        public void formula2()  //parent 2 method
        {
            double pi = 3.14;
            Console.WriteLine("Please Input Radius (in milimeters):");
            double radius = Convert.ToDouble(Console.ReadLine()) * 2;
            double result = pi * radius;
            Console.WriteLine("The total area of your described shape is: \n{0}mm", result);
        }
        public void formula3()  //parent 3 method
        {
            Console.WriteLine("Please Input side length (in milimeters):");
            double length = Convert.ToDouble(Console.ReadLine());
            double result = length * length;
            Console.WriteLine("The total area of your described shape is: \n{0}mm", result);
        }
    }
    public class Circle : Shape //derived child : parent class
    {
        public void circleArea()    //child 1 method
        {
            Console.WriteLine("You have selected 'Circle'");
            formula2(); //inherited parent method
        }
    }
    public class Square : Shape //derived child 2 : parent class
    {
        public void squareArea()    // child 2 method
        {
            Console.WriteLine("You have selected 'Square'");
            formula3(); //inherited parent method
        }
    }
    public class Rectangle : Shape  //derived child 3 : parent class
    {
        public void rectangleArea() //child 3 method
        {
            Console.WriteLine("You have selected 'Rectangle'");
            formula1(); //inherited parent class
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle a = new Circle();    //object_name = new_classname();
            Square b = new Square();
            Rectangle c = new Rectangle();
            Console.WriteLine("Please select a shape...");
            Console.WriteLine("1. Circle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Rectangle");
            int method = Convert.ToInt32(Console.ReadLine());
            if (method > 3)
            {
                Console.WriteLine("Invalid selection! \nPlease try again.");
                return;
            }
            if (method < 1)
            {
                Console.WriteLine("Invalid selection! \nPlease try again.");
                return;
            }
            switch (method) //switch case to call child : parent class
            {
                case 1:
                    a.circleArea();
                    break;
                case 2:
                    b.squareArea();
                    break;
                case 3:
                    c.rectangleArea();
                    break;
            }
        }
    }
}
