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
            MoneyParent moneyP = new MoneyParent("Scrooge McDuck", "SAM US SAVINGS BANK", 0);
            moneyP.BankInfo();
            CheckingAcc check1 = new CheckingAcc(0, 0);
            check1.PutIn();
            CheckingAcc check2 = new CheckingAcc(0, 0);
            check2.Takeaway1();
            CheckingAcc check3 = new CheckingAcc(0, 0);
            check3.OverallBalance1();
            SavingsAcc sav1 = new SavingsAcc(0, 0);
            sav1.PutIn2();
            SavingsAcc sav2 = new SavingsAcc(0, 0);
            sav2.Takeaway2();
            SavingsAcc sav3 = new SavingsAcc(0, 0);
            sav3.OverallBalance2();
            ReserveAcc resv1 = new ReserveAcc(0, 0);
            resv1.PutIn3();
            ReserveAcc resv2 = new ReserveAcc(0, 0);
            resv2.Takeaway3();
            ReserveAcc resv3 = new ReserveAcc(0, 0);
            resv3.OverallBalance3();
            
        }
    }
}
