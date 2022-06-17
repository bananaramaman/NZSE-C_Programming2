using System;
using System.Collections;

namespace FA1_StackProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack even = new Stack();
            even.Push(0);
            even.Push(1);
            even.Push(2);
            even.Push(3);
            even.Push(4);
            even.Push(5);
            even.Push(6);
            even.Push(7);
            even.Push(8);
            even.Push(9);
            even.Push(10);

            Console.WriteLine("Even numbers from 0 - 10");
            foreach (int n in even)
            {
                if (n % 2 == 0)
                {
                    Console.WriteLine(n + " ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("highest value {0}",even.Peek());
            Console.WriteLine();
            even.Pop();
            even.Pop();
            even.Pop();
            Console.WriteLine("Current stack minus the top three values");
            foreach (int n in even)
            {
                Console.WriteLine(n + "");
            }
        }
    }
}
