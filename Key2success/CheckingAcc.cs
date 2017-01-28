using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key2success

{
    class CheckingAcc : MoneyParent
    {
        private string  checking;

       
        public CheckingAcc(string checking) : base("Scrooge McDuck", "SAM US SAVINGS BANK", 0,0,0)
        {
            this.checking = checking;  
        }   
        public void Checking()
            {
            }

        
        public void Cashin()
        {
            this.PutIn();
            return;
        }
       

        public void Itsgone()
        {
            this.Takeaway();
            
        }
        //public void OverallBalance1()
        //{
            
        //    Console.WriteLine("You have now deducted: " + "$" + overallBalance);
        //    return;
        //}
        //public void Lotal1()
        //{
        //    this.OverallBalance1();
        //}

    }


}


