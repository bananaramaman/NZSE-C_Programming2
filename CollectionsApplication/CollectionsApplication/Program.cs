using System;
using System.Collections;
// compulsory to be defined

namespace CollectionsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();

            st.Push('R');
            st.Push('S');
            st.Push('T');
            st.Push('U');
            st.Push('V');
            st.Push('W');

            Console.WriteLine("Current stack");
            foreach (char c in st)
            {
                Console.WriteLine(c + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Does the user wish to 'Push' or 'Pop' any further values?");
            Console.WriteLine("Press [1] for PUSH\nPress [2] for POP");
            Console.WriteLine();
            int x = Convert.ToInt32(Console.ReadLine());

            if (x == 1)
            {
                st.Push('X');
                st.Push('Y');
                st.Push('Z');
                Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
                Console.WriteLine("Current stack");
                foreach (char c in st)
                {
                    Console.WriteLine(c + " ");
                }
                Console.WriteLine();
            }
            if (x == 2)
            {
                Console.WriteLine("Removing values...");
                st.Pop();
                st.Pop();
                st.Pop();
                st.Pop();
                foreach (char c in st)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
            if (x != 1 && x != 2)
            {
                Console.WriteLine("Input error\n-- Reticulating splines --");
                Console.ReadKey();
            }
            
        }
    }
}
