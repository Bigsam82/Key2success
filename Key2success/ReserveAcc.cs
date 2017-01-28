using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key2success
{
    class ReserveAcc : MoneyParent
    {
        private string reserve;

     
        
        public ReserveAcc(string reserve) : base("Scrooge McDuck", "SAM US SAVINGS BANK", 0,0,0)
        {
            this.reserve=reserve;
       
            
        }
        public void PutIn3()
        {
            Console.WriteLine("How much will you deposit into your Reserve account Mr. McDuck");
            double userinput1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Reserve account total is = " + "$" + userinput1);
        }
        public void Cashin()
        {
            this.PutIn3();
        }
       
        public void Itsgone()
        {
            this.Takeaway();
                  
        }
      
        }

    }
