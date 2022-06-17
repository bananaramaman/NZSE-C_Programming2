using System;

namespace HierachicalInheritance
{
    class A //base class
    {
        public void msg()   //Base (Parent) class
        {
            Console.WriteLine("This is A (Parent) class Method");
        }
    }
    class B : A     //derived (child) class 1
    {
        public void info()
        {
            msg();  //Base (Parent) class derived
            Console.WriteLine("This is B (Child) class Method");
        }
    }
    class C : A     //derived child class 2
    {
        public void getinfo()
        {
            msg();  //Base (Parent) class derived
            Console.WriteLine("this is C (Child) class Method");
        }
    }
    class Prog
    {
        public static void Main(string[] args)  //main method
        {
            A objectA = new A();    //classname object_name = new classname();
            B objectB = new B();
            C objectC = new C();

            objectA.msg();
            objectB.info();
            objectC.getinfo();
        }
    }
}
