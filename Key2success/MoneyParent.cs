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
        // private int depositFunds;

        // private int withDrawfunds;
        public int AccountBalance
        {
            get { return this.AccountBalance; }
            set { this.AccountBalance = value; }
        }

        public  MoneyParent(string clientInformation, string bankName, int accountBalances)
        {
            this.clientInformation = "Scrooge McDuck";
            this.bankName = "SAM US SAVINGS BANK";
            this.accountBalance = 0;
        }
        
        public void BankInfo()
        {
            Console.WriteLine("Bank Name: " + bankName);
            Console.WriteLine("Clients name: " + clientInformation);
            Console.WriteLine("Your account balance is: " + accountBalance);
            Console.WriteLine();
        }
       
    }
}
