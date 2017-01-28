using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key2success

{
    class CheckingAcc : MoneyParent
    {
        private string checking;


        public CheckingAcc(string checking) : base("Scrooge McDuck", "SAM US SAVINGS BANK", 0, 0, 0)
        {
            this.checking = checking;
        }
        public void Typeaccount()
        {
            Console.WriteLine("Your ending checking  account balance is " +"$"+ overallBalance);
        }
        public void Tellem()
        {
            this.Typeaccount();
        }

    }

}
