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

        private int accountBalance;


        public int AccountBalance
        {
            get { return this.AccountBalance; }
            set { this.AccountBalance = value; }
        }

        public MoneyParent(string clientInformation, string bankName, int accountBalances)
        {
            this.clientInformation = "Scrooge McDuck";
            this.bankName = "SAM US SAVINGS BANK";
            this.accountBalance = 0;
        }

        public virtual void BankInfo()
        {
            Console.WriteLine("Hello " + clientInformation);
            Console.WriteLine("You have three different accounts with " + bankName + "\n a Checking with a account balance of: " + "$" + accountBalance + "\n Savings with a account balance of: " + "$" + accountBalance + "\n and a Reserve account with a balance of: " + "$" + accountBalance);

        }
       // public void Endgame()
       // {
         //   Console.WriteLine("Thank you for using " + bankName + "have a fantastic day");
       // }

    }
}

