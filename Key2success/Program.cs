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
            MoneyParent moneyP = new MoneyParent("Scrooge McDuck", "SAM US SAVINGS BANK", 233451, 0,0,0);
            moneyP.BankInfo();

            CheckingAcc check1 = new CheckingAcc("checking");
            check1.PutIn();
            check1.Takeaway();
            check1.Typeaccount();
           
            SavingsAcc sav1 = new SavingsAcc("savings");
            sav1.PutIn();
            sav1.Takeaway();
            sav1.Typeaccount1();
           
            ReserveAcc resv1 = new ReserveAcc("reserve");
            resv1.PutIn();
            resv1.Takeaway();
            resv1.Typeaccount2();
            resv1.Endgame();

            //StreamBank str1 = new StreamBank("C:/Documents/visual studio 2015/Projects/Key2success", 0, "bank.txt", null);
            //str1.ToString();
            //attempted try at streamwriter
        }
    }
}

