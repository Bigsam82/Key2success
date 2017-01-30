using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key2success
{
    class MoneyParent
    {
        private string clientInformation;//fields
        private string bankName;
       // private string reader;
       

        protected double overallBalance;
       

        private int accountBalance;
        private int accountNumber;

        public int AccountBalance
        {
            get { return this.AccountBalance; }
            set { this.AccountBalance = value; }
        }

        protected double OverallBalance
        {
            get { return this.OverallBalance; }
            set { this.OverallBalance = value; }
        }

        public MoneyParent(string clientInformation, string bankName,int accountNumber, int accountBalances, double overallBalance,double userinput)//greeting when user opens account did not make code to generate random account number hard coded
        {
            this.clientInformation = "Scrooge McDuck";
            this.bankName = "SAM US SAVINGS BANK";
            this.accountNumber = 233451;
            this.accountBalance = 0;
            this.overallBalance = overallBalance;
            //this.reader = "bank.txt";

        }

        public virtual void BankInfo()//method to produce greeting with time stamp pn it and account balances
        {
            Console.WriteLine("Hello " + clientInformation);
            Console.WriteLine("You have three different accounts with " + bankName + "\n a Checking with a account balance of: " + "$" + accountBalance + "\n Savings with a account balance of: " + "$" + accountBalance + "\n and a Reserve account with a balance of: " + "$" + accountBalance+" Your account number: " +accountNumber+ " \n will be used for all three accounts");
            DateTime date = DateTime.Now;
            Console.WriteLine(DateTime.Now);

        }
        public void PutIn()//method to ask what would the user want to deposit and total balance after words this is inherited thru all 3 classes
        {
            Console.WriteLine("How much will you deposit:");
            double userinput1 = int.Parse(Console.ReadLine());
            overallBalance += userinput1;
            Console.WriteLine(" Account total is = " + "$" + overallBalance);
            Console.WriteLine("If you would like to quit press EXIT");
            
        }
        public void Takeaway()//method to ask what would the user want to withdraw and total balance after words this is inherited thru all 3 classes
        
            {
            Console.WriteLine("How much would you like to withdraw:");
            double userinput1 = int.Parse(Console.ReadLine());
            overallBalance -= userinput1;
            Console.WriteLine("Your account overall balance: " + "$" + overallBalance);

        }
         public void Endgame()//message that closes out the program at the end is inherited from all three classes
        {
           Console.WriteLine("Thank you for using " + bankName + " have a fantastic day");
        }
       // public void Strm()//method for streamwriter I could not get to work
       // {
       //     Console.WriteLine(reader);
        }
    }


