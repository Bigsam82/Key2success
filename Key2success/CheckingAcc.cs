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
      //  private string streamBank;
      //  private int lineNumber;
      //  private string line;


        public CheckingAcc(string checking) : base("Scrooge McDuck", "SAM US SAVINGS BANK", 233451, 0, 0, 0)
        {
            this.checking = checking;
            //this.streamBank = "C:/Documents/visual studio 2015/Projects/Key2success";
            //this.lineNumber = 0;
            //this.line = line;
        }
        public void Typeaccount()
        {
            Console.WriteLine("Your ending checking  account balance is " +"$"+ overallBalance);
        }
        public void Tellem()
        {
            this.Typeaccount();
        }
      //  public void StreamMe()
       // {
         //   Console.WriteLine(streamBank);
           // StreamBank reader = new StreamBank("checking.txt");
           // using (checking) ;
          //  {
            
           //     reader.Write(StreamMe);
          //  }
        }

        

    }


