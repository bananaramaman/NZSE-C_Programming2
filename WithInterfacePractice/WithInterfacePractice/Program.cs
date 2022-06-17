using System;
using System.Collections;
namespace WithInterfacePractice
{
    //C# program to illustrate how to implement multiple class inheritance using interfaces

    // Interface 1
    interface GFG1
    {
        void languages();
    }
    // parent class 1
    class Goal1 : GFG1
    {
        // providing the implementation of languages() method
        public void languages()
        {
            // creating ArrayList
            ArrayList My_list = new ArrayList();
            // adding elements in the My_list ArrayList
            My_list.Add("C");
            My_list.Add("C++");
            My_list.Add("C#");
            My_list.Add("Java");

            Console.WriteLine("Program languages");
            foreach (var elements in My_list)
            {
                Console.WriteLine(elements);
            }
        }
    }
    // interface 2
    interface GFG2
    {
        void courses();
    }
    // parent class 2
    class Goal2 : GFG2
    {
        // providing the implementation of courses() method
        public void courses()
        {
            // creating ArrayList
            ArrayList My_list = new ArrayList();

            // adding elements in the My_list ArrayList
            My_list.Add("System Design");
            My_list.Add("Fork Python");
            My_list.Add("DSA Classes");
            My_list.Add("Fork Java");

            Console.WriteLine("\nCourse List");
            foreach (var elements in My_list)
            {
                Console.WriteLine(elements);
            }
        }
    }
    // child class
    class GoalsforGoalies : GFG1, GFG2
    {
        // creating objects of Geeks1 and Geeks2 class
        Goal1 obj1 = new Goal1();
        Goal2 obj2 = new Goal2();

        public void languages()
        {
            obj1.languages();
        }
        public void courses()
        {
            obj2.courses();
        }
    }
    // driver class
    public class GFG
    {
        // main method
        static public void Main()
        {
            // creating object of GoalsforGoalies class
            GoalsforGoalies obj = new GoalsforGoalies();
            obj.languages();
            obj.courses();

            Console.ReadKey();
        }
    }
}
