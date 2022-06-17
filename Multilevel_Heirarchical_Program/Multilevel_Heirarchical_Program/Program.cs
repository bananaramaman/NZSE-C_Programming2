using System;

namespace Multilevel_Inheritance
{
    public class Person     //Base class (Parent)
    {
        public void persondet() //parent_Method
        {
            Console.WriteLine("This is the person class");
        }
    }

    public class Bird : Person  //Derived child : parent class
    {
        public void birddet()   //child 1 Method
        {
            persondet(); //inherited parent method
            Console.WriteLine("This is a bird class");
        }
    }
    public class Animal : Bird  //Derived Child 2 : Child 1 class
    {
        public void animaldet() //child 2 Method
        {
            persondet(); //inherited parent method
            birddet();  //inherited child 1 method
            Console.WriteLine("This is an animal class");
        }
    }
    class Prog
    {
        public static void Main(string[] args)
        {
            //classname object_name = new classname();

            Person p = new Person();
            Bird b = new Bird();
            Animal a = new Animal();

            p.persondet();
            b.birddet();
            a.animaldet();

        }
    }
}
