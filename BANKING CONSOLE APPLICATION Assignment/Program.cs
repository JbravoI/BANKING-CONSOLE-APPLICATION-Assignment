using System;

namespace BANKING_CONSOLE_APPLICATION_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            string loan;

            Console.WriteLine("Welcome to WEMA Bank Loan Platform!");
            Console.WriteLine("Kindly fill in your details for identification purpose!");

            //Action
            LoanRemission NewClient = new LoanRemission();

            //Registering new client details
            Console.WriteLine("Kindly input your fullname");
            NewClient.UserName = Console.ReadLine();
            Console.WriteLine("Kindly input your Account Number");
            NewClient.AcctNum = Console.ReadLine();
            Console.WriteLine("Kindly input your Guarantors name");
            NewClient.GuarantorsName = Console.ReadLine();

            Console.WriteLine("Kindly input (1 => Quick Loan), (2 => Loan Rectification), (3 => Clear Loan balance),!");
            // inputting clients decision
            loan = Console.ReadLine();
            a = Int32.Parse(loan);

            //if statement used to decide actions to make

            //Code for choosing Option 1
            if (a == 1)
            {
                Console.WriteLine("Welcome to WEMA Bank Quick Loan Platform!");
                //bringing up user amount in the account
                int UserAcc = 275000;

                Console.WriteLine($"Your Acct {NewClient.AcctNum} is having a Balance of {UserAcc} naira only");

                // showing user how much he or she can loan
                int maxloan, minloan;
                string L2;
                minloan = UserAcc - 100000;
                maxloan = UserAcc - 75000;

                Console.WriteLine($"You can only loan {maxloan} as maximumloan and {minloan} as minimum loan");

                Console.WriteLine($"Kindly input (1 => for {maxloan} ), (2 => for {minloan}), (3 => Cancel loan process),!");
                L2 = Console.ReadLine();
                int loanAgree = Int32.Parse(L2);
                        if(loanAgree == 1)
                        {
                             Console.WriteLine($"Thanks for using WEMA Bank Quick Loan Platform, {maxloan} will be depositedin your account {NewClient.AcctNum}  ");
                            }
                        else if (loanAgree == 2)
                            {
                            Console.WriteLine($"Thanks for using WEMA Bank Quick Loan Platform, {minloan} will be depositedin your account {NewClient.AcctNum}  ");
                         }
                        else if (loanAgree == 3)
                        {
                            Console.WriteLine($"Thanks for using WEMA Bank Quick Loan Platform, Loan process has been terminated!");
                        }
                        else
                        {
                             Console.WriteLine($"Kindly input (1 => for {maxloan} ), (2 => for {minloan}), (3 => Cancel loan process),!");
                }
            }

            //Code for choosing Option 2
            else if (a == 2)
            {
                Console.WriteLine("Welcome to WEMA Bank Loan Rectification Platform!");
                Console.WriteLine("Kindly input your BVN number");
                NewClient.BVNnumber = Int32.Parse(Console.ReadLine());
                Console.WriteLine($"Your Acct {NewClient.AcctNum} and BVN Number { NewClient.BVNnumber} will be forwarded for rectification ");
            }
            else if (a == 3)
            {
                Console.WriteLine("Welcome to Clear Loan balance");
                Console.WriteLine("Kindly try again later as platform is not available!");
            }
            else
            {
                Console.WriteLine("Please re-enter the digits");

            }
            //actions to be done


        }
    }


    class LoanRemission
    {
        public LoanRemission()
        {

        }

        ~LoanRemission()
        {
            Console.WriteLine("Thanks for banking with us");
        }
        //Creating of three properties

        public string UserName { get; set; }
        public DateTime DOB { get; set; }
        public DateTime ReturnDate { get; set; }

        public string AcctNum { get; set; }
        public string GuarantorsName { get; set; }

        //Creating of three methods

        public int BVNnumber
        {
            get; set; 

        }

        public int AccountNumber()
        {
            Console.WriteLine("Input your Account Number");
            string Accountber = Console.ReadLine();
            Console.WriteLine($"Your account Number {Accountber} has been recorded");
            int AccountNumber = Int32.Parse(Accountber);
            return AccountNumber;

            //decimal Payments()
            //{
            ///    return 3.4 %;
            // }
        }
    }
    class QuickLoan
    {
        public int loan()
        {
            Console.WriteLine("How much do want to loan!");
            string loanamount = Console.ReadLine();
            int loan = int.Parse(loanamount);
            return loan;

        }

    }

    class acctbalance
    {
        double acctB()
        {
            return 250000.38d;
        }
    }

}

