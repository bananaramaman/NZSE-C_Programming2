using System;

namespace FA2_Interface
{
    public interface IAccount   //You are required to use an interface IAccount that declares functions getAccountStatus() and getEnrolmentType().
    {
        void getAccountStatus();
        void getEnrolmentType();
    }
    public class domesticCustomer : IAccount    //There are two classes DomesticCustomer and InternationalCustomer which implements the interfaces.
    {
        private double ActualMortgage;
        private double PaidMortgage;
        private double amount;
        private string customerType;
        private double mortgageFine;
        public domesticCustomer(double a, double b, string c, double d)
        {
            ActualMortgage = a;
            PaidMortgage = b;
            customerType = c;
            mortgageFine = d;
        }
        public void getEnrolmentType()
        {
            Console.WriteLine("Your account is listed as [{0}]", customerType);
        }
        public void getAccountStatus()
        {
            amount = ActualMortgage - PaidMortgage;
            getEnrolmentType();
            if (amount <= 0)
            {
                Console.WriteLine("Congratulations, you have paid off your mortgage!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You have paid ${0} towards your mortgage\nwith ${1} remaining\n${2} in interest will be added to the total", PaidMortgage, amount, mortgageFine);
                Console.WriteLine("Have a nice day!");
            }
        }
    }
    public class internationalCustomer : IAccount
    {
        private double ActualMortgage;
        private double PaidMortgage;
        private double amount;
        private string customerType;
        private double mortgageFine;
        public internationalCustomer(double a, double b, string c, double d)
        {
            ActualMortgage = a;
            PaidMortgage = b;
            customerType = c;
            mortgageFine = d;
        }
        public void getEnrolmentType()
        {
            Console.WriteLine("Your account is listed as [{0}]", customerType);
        }
        public void getAccountStatus()
        {
            amount = ActualMortgage - PaidMortgage;
            getEnrolmentType();
            if (amount <= 0)
            {
                Console.WriteLine("Congratulations, you have paid off your mortgage!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You have paid ${0} towards your mortgage\nwith ${1} remaining\n${2} in interest will be added to the total", PaidMortgage, amount, mortgageFine);
                Console.WriteLine("Have a nice day!");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double mortgageFine;
            string customerType;
            Console.WriteLine("Please Enter your full name");
            string customerName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Now, please enter your state issued tax identification serial number.\n(Imprinted on the lower right quadrant of your eyeball.\nPlease contact your local tax enforcement administrator if you require assistance");
            int idNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Input your total mortgage balance for the last financial year");  //Ask the customer to input their annual mortgage amount for the last financial year - store this as ActualMortgage.
            double ActualMortagage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("No please input the total amount paid towards your mortgage for the last financial year");   //Ask the customer to input the mortgage paid for the last financial year - store this as PaidMortgage
            double PaidMortgage = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Are you an international customer Y/N?");    //Ask the customer to choose if they are a Domestic Customer or an International Customer - you can use a switch case here.
            ConsoleKey international;
            international = Console.ReadKey().Key;
            if (international != ConsoleKey.Enter)
            {
                Console.WriteLine();
            }
            switch (international) //The fine for domestic customer is 800NZD and the fine for international customer is 2000NZD - store this as MortgageFine
            {
                case ConsoleKey.Y:
                    mortgageFine = 2000;
                    customerType = "international";
                    internationalCustomer x = new internationalCustomer(ActualMortagage, PaidMortgage, customerType, mortgageFine);
                    x.getAccountStatus();
                    break;

                case ConsoleKey.N:
                    mortgageFine = 800;
                    customerType = "Domestic";
                    domesticCustomer y = new domesticCustomer(ActualMortagage, PaidMortgage, customerType, mortgageFine);
                    y.getAccountStatus();
                    break;
            }
        }
    }
}
