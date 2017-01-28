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
       
       
        
        public SavingsAcc(string Savings) : base("Scrooge McDuck", "SAM US SAVINGS BANK", 0,0,0)
        {
            this.Savings= Savings;  
        }
        
        public void Cashin3()
        {
            this.PutIn();
            return;
        }
       
        public void Itsgone()
        {
            this.Takeaway();
        }
       
    }
}