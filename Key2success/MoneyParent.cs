using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key2success
{
    class MoneyParent
    {
        private string clientInformation;
        private string bankName;

        protected double overallBalance;
       // protected double userinput1;

        private int accountBalance;


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

        public MoneyParent(string clientInformation, string bankName, int accountBalances, double overallBalance,double userinput)
        {
            this.clientInformation = "Scrooge McDuck";
            this.bankName = "SAM US SAVINGS BANK";
            this.accountBalance = 0;
            this.overallBalance = overallBalance;
           // this.userinput1 = userinput1;

        }

        public virtual void BankInfo()
        {
            Console.WriteLine("Hello " + clientInformation);
            Console.WriteLine("You have three different accounts with " + bankName + "\n a Checking with a account balance of: " + "$" + accountBalance + "\n Savings with a account balance of: " + "$" + accountBalance + "\n and a Reserve account with a balance of: " + "$" + accountBalance);

        }
        public void PutIn()
        {
            Console.WriteLine("How much will you deposit:");
            double userinput1 = int.Parse(Console.ReadLine());
            overallBalance += userinput1;
            Console.WriteLine(" Account total is = " + "$" + overallBalance);
        }
        public void Takeaway()
        {
            Console.WriteLine("How much would you like to withdraw:");
            double userinput1 = int.Parse(Console.ReadLine());
            overallBalance -= userinput1;
            Console.WriteLine("Your account overall balance: " + "$" + overallBalance);

        }
        // public void Endgame()
        // {
        //   Console.WriteLine("Thank you for using " + bankName + "have a fantastic day");
        // }

    }
}

