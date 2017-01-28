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
            MoneyParent moneyP = new MoneyParent("Scrooge McDuck", "SAM US SAVINGS BANK", 0,0,0);
            moneyP.BankInfo();

            CheckingAcc check1 = new CheckingAcc("checking");
            check1.PutIn();

            CheckingAcc check2 = new CheckingAcc("checking");
            check2.Takeaway();
           
            SavingsAcc sav1 = new SavingsAcc("savings");
            sav1.PutIn();
            SavingsAcc sav2 = new SavingsAcc("savings");
            sav2.Takeaway();
           
            ReserveAcc resv1 = new ReserveAcc("reserve");
            resv1.PutIn();
            ReserveAcc resv2 = new ReserveAcc("reserve");
            resv2.Takeaway();
            
            
        }
    }
}
