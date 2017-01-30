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

     
        
        public ReserveAcc(string reserve) : base("Scrooge McDuck", "SAM US SAVINGS BANK", 233451, 0,0,0)//constructor
        {
            this.reserve=reserve;   
        }
        public void Typeaccount2()
        {
            Console.WriteLine("Your ending Reserve account balance is " +"$" +overallBalance);//created this method to let user know what their overall balnace is and the type of a account they had
            
            }
        public void Tellem2()
        {
            this.Typeaccount2();
        }

       }

      }
