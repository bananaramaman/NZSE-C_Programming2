using System;

namespace PolymorphismImplementation
{
    public class MethodOverloading    //base class
    {
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double Add(double b, double a)
        {
            return b + a;
        }
        public string Add(string a)
        {
            return a;
        }
    }
    class Prog
    {
        public static void Main(string[] args)
        {
            MethodOverloading data = new MethodOverloading();
            int add1 = data.Add(1, 4, 88);
            double add2 = data.Add(420.69, 19.84);
            string add3 = data.Add("qwerty");

            Console.WriteLine(add3);
            Console.WriteLine(add2);
            Console.WriteLine(add1);
        }
    }
}
