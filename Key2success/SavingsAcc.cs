using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key2success
{
    class SavingsAcc : MoneyParent
    {
        private string Savings;
       
       
        
        public SavingsAcc(string Savings) : base("Scrooge McDuck", "SAM US SAVINGS BANK", 233451, 0,0,0)//constructor
        {
            this.Savings= Savings;  
        }
        public void Typeaccount1()
        {
            Console.WriteLine("Your ending savings account balance is " +"$"+ overallBalance);//created this method to let user know what their overall balnace is and the type of a account they had
            
            }
        public void Tellem1()
        {
            this.Typeaccount1();
        }



    }
}