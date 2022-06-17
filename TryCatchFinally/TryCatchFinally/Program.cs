using System;

namespace TryCatchFinally
{
    class DivNumbers
    {
        int result;
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("ERROR! Reticulating splines\n{0}", e);
                System.Environment.Exit(0);
            }
            finally
            {
                Console.WriteLine("Result: {0}", result);
            }
        }
        static void Main(String[] args)
        {
            DivNumbers d = new DivNumbers();
            Console.WriteLine("Please enter the first number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int y = Convert.ToInt32(Console.ReadLine());
            d.division(x, y);
            Console.ReadKey();
        }
    }
}
