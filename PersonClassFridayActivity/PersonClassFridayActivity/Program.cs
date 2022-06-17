using System;

namespace PersonClassFridayActivity
{
  
    class Person  // base class
    {
        public virtual void PersonAge()
        {
            Console.WriteLine(30);
        }
        public virtual void PersonCountry()
        {
            Console.WriteLine("New Zealand");
        }
    }
    class Employee : Person  // Inherited child class
    {
        public void EmployeeID()
        {
            Console.WriteLine(54321);
        }
        public void AddressDet()
        {
            Console.WriteLine("42 wallabe Lane Sydney");
        }
        public void HireDate()
        {
            Console.WriteLine("15/03/19");
        }
    }
    class Contractor : Employee
    {
        public void EndDate()
        {
            Console.WriteLine("31/03/22");
        }
        public void HourlyRate()
        {
            Console.WriteLine(45.20);
        }
    }
    class PermanentStaff : Employee
    {
        public void StartDate()
        {
            Console.WriteLine("10/01/15");
        }
        public void Salary()
        {
            Console.WriteLine(69000);
        }
    }
    class Prog
    {
        public static void Main(string[] args)
        {
            Person PersonInfo = new Person();
            Employee EmployeeInfo = new Employee();
            Contractor ContractorInfo = new Contractor();
            PermanentStaff StaffInfo = new PermanentStaff();

            PersonInfo.PersonAge();
            PersonInfo.PersonCountry();
            EmployeeInfo.EmployeeID();
            EmployeeInfo.AddressDet();
            EmployeeInfo.HireDate();
            ContractorInfo.EndDate();
            ContractorInfo.HourlyRate();
            StaffInfo.StartDate();
            StaffInfo.Salary();
        }
    }
}
