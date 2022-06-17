using System;

namespace MethodOverloadingPoly
{
    public class MethodOverloadingPoly
    {
        public double Add(double a, double b, double c)
        {
            return a + b + c;   
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
    class Prog
    {
        public static void Main(String[] args)
        {
            MethodOverloadingPoly data = new MethodOverloadingPoly();
            double add3 = data.Add(7.62, 5.56, 10.0);
            int add2 = data.Add(9, 45);
            Console.WriteLine(add3);
            Console.WriteLine(add2);
        }
    }
}
