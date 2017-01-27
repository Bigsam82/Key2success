using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key2success
{
    class Program
    {
        static void Main(string[] args)
        {
            MoneyParent moneyP = new MoneyParent("Scrooge McDuck", "SAM US SAVINGS BANK",0);
            moneyP.BankInfo();
        }
    }
}
