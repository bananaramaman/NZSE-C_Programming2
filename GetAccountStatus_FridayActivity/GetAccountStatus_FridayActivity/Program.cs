using System;

namespace GetAccountStatus_FridayActivity
{
   public interface IAccount    // interface 
    {
        void getAccountStatus();    // function 1
        double getAmount();     // function 2
    }
    class Account : IAccount  // base class implements interface 
    {
        private string StudentName;
        private bool StudyStatus;
        private double amount;

        public Account(string a, bool b, double c)
        {
            StudentName = a;
            StudyStatus = b;
            amount = c;
        }
        public double getAmount() // function returns ammount
        {
            return amount;
        }
        public void getAccountStatus() // function calls if else statment
        {  
            Console.WriteLine("Student name: {0}", StudentName);
            if (StudyStatus == true)
            {
                Console.WriteLine("Domestic Student");
                Console.WriteLine("Fees covered under fees free policy");
                Console.WriteLine("Course fees: ${0} -PAID IN FULL-", getAmount());
            }
            else
            {
                Console.WriteLine("International Student");
                Console.WriteLine("Outstanding course fees: ${0}", getAmount());
            }
            Console.WriteLine();
        }
    }
    class prog
    {
        static void Main(String[] args)
        {
            Account s1 = new Account("Brian O'Conner", true, 54288.62);
            Account s2 = new Account("Dominic Toretto", false, 39519.74);
            Account s3 = new Account("Letty Oritz", false, 112281.25);
            Account s4 = new Account("Mia Torretto", true, 42757.32);
            Account s5 = new Account("Roman Pearce", true, 101817.87);
            Account s6 = new Account("Tej Parker", false, 115079.06);
            Account s7 = new Account("Sean Boswell", true, 16341.94);
            Account s8 = new Account("Han Lue", false, 109556.61);
            Account s9 = new Account("Luke Hobbs", true, 88677.79);

            s1.getAccountStatus();
            s2.getAccountStatus();
            s3.getAccountStatus();
            s4.getAccountStatus();
            s5.getAccountStatus();
            s6.getAccountStatus();
            s7.getAccountStatus();
            s8.getAccountStatus();
            s9.getAccountStatus();
            Console.ReadKey();
        }
    }
}
