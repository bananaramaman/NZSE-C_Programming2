using System;

namespace InheritanceProgrammingPactice01
{
    public class Account //base class or parent class
    {
        public void credit()
        {
            Console.WriteLine("Deposited transaction");
        }
    }
    public class debitAccount : Account //defining a derived class from the base class
    {
        public void debit()
        {
            credit();    //derived class method
            Console.WriteLine("Balance withdrawn");
        }
    }

    class Prog
    {
        public static void Main(string[] args)
        {
            //classname object_name = new classname();

            Account ac = new Account();
            ac.credit();
            debitAccount db = new debitAccount();
            db.debit();
        }
    }

   
}
