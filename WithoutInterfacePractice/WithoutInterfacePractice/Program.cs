using System;
using System.Collections;

// C# program to illustrate multiple class inheritance
namespace WithoutInterfacePractice
{
   //parent class 1
   class Goal1
    {
        //Providinig the implementation of languages() method
        public void languages()
        {
            // creating ArrayList
            ArrayList My_list = new ArrayList();

            // Adding elements in the ArrayList
            My_list.Add("C");
            My_list.Add("C++");
            My_list.Add("C#");
            My_list.Add("Java");

            Console.WriteLine("Program Languages");
            
            foreach (var elements in My_list)
            {
                Console.WriteLine(elements);
            }
        }
    }
    //Parent class 2
    class Goal2
    {
        //Providing the implementation or courses() method
        public void courses()
        {
            // creating ArrayList 
            ArrayList My_list = new ArrayList();
            // adding elements to the ArrayList
            My_list.Add("System Design");
            My_list.Add("Fork Python");
            My_list.Add("Geeks Classes DSA");
            My_list.Add("Fork Java");

            Console.WriteLine("\nCourses List:");
            foreach (var elements in My_list)
            {
                Console.WriteLine(elements);
            }
        }
    }
    // child class
    class GoalsforGoalies : Goal1, Goal2
    {

    }

    public class GFG
    {
        //main method
        static public void Main()
        {
            //creating object of GoalsforGoalies class
            GoalsforGoalies obj = new GoalsforGoalies();
            obj.languages();
            obj.courses();
        }
    }
}
