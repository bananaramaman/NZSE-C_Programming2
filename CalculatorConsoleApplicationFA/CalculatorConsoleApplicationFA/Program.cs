using System;

namespace CalculatorConsoleApplicationFA
{
    public interface Operation
    {
        int IntOp();
        float FloatOp();
        int FloatToIntOp();
    }
    class Addition : Operation
    {
        private double num1;
        private double num2;
        public Addition(double a, double b)
        {
            num1 = a;
            num2 = b;
        }
        public int IntOp()
        {
            double results = num1 + num2;
            int result = (int)results;
            Console.WriteLine("int = {0}", result);
            return result;
        }
        public float FloatOp()
        {
            double results = num1 + num2;
            float result = (float)results;
            Console.WriteLine("Float = {0}", result);
            return result;
        }
        public int FloatToIntOp()
        {
            double resulting = num1 + num2;
            float results = (float)resulting;
            int result = (int)results;
            Console.WriteLine("Float = {0} to Int = {1}", results, result);
            return result;
        }
    }
    class Subtraction : Operation
    {
        private double num1;
        private double num2;
        public Subtraction(double a, double b)
        {
            num1 = a;
            num2 = b;
        }
        public int IntOp()
        {
            double results = num1 - num2;
            int result = (int)results;
            Console.WriteLine("int = {0}", result);
            return result;
        }
        public float FloatOp()
        {
            double results = num1 - num2;
            float result = (float)results;
            Console.WriteLine("Float = {0}", result);
            return result;
        }
        public int FloatToIntOp()
        {
            double resulting = num1 - num2;
            float results = (float)resulting;
            int result = (int)results;
            Console.WriteLine("Float = {0} to Int = {1}", results, result);
            return result;
        }
    }
    class Multiplication : Operation
    {
        private double num1;
        private double num2;
        public Multiplication(double a, double b)
        {
            num1 = a;
            num2 = b;
        }
        public int IntOp()
        {
            double results = num1 * num2;
            int result = (int)results;
            Console.WriteLine("int = {0}", result);
            return result;
        }
        public float FloatOp()
        {
            double results = num1 * num2;
            float result = (float)results;
            Console.WriteLine("Float = {0}", result);
            return result;
        }
        public int FloatToIntOp()
        {
            double resulting = num1 * num2;
            float results = (float)resulting;
            int result = (int)results;
            Console.WriteLine("Float = {0} to Int = {1}", results, result);
            return result;
        }
    }
    class Division : Operation
    {
        private double num1;
        private double num2;
        public Division(double a, double b)
        {
            num1 = a;
            num2 = b;
        }
        public int IntOp()
        {
            double results = num1 / num2;
            int result = (int)results;
            Console.WriteLine("int = {0}", result);
            return result;
        }
        public float FloatOp()
        {
            double results = num1 / num2;
            float result = (float)results;
            Console.WriteLine("Float = {0}", result);
            return result;
        }
        public int FloatToIntOp()
        {
            double resulting = num1 / num2;
            float results = (float)resulting;
            int result = (int)results;
            Console.WriteLine("Float = {0} to Int = {1}", results, result);
            return result;
        }
    }
    class prog
    {
        static void Main(String[] args)
        {
            Console.WriteLine("please input first number");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Choose an operation\n[1] = Addition\n[2] = Subtraction\n[3] = Multiplication\n[4] = Division\n");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please input second number");
            double z = Convert.ToDouble(Console.ReadLine());
            if (x == 1)
            {
                Addition s1 = new Addition(y, z);
                s1.IntOp();
                s1.FloatOp();
                s1.FloatToIntOp();
            }
            if (x == 2)
            {
                Subtraction s1 = new Subtraction(y, z);
                s1.IntOp();
                s1.FloatOp();
                s1.FloatToIntOp();
            }
            if (x == 3)
            {
                Multiplication s1 = new Multiplication(y, z);
                s1.IntOp();
                s1.FloatOp();
                s1.FloatToIntOp();
            }
            if (x == 4)
            {
                Division s1 = new Division(y, z);
                s1.IntOp();
                s1.FloatOp();
                s1.FloatToIntOp();
            }
        }
    }
}












