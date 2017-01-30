using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key2success

{
    class CheckingAcc : MoneyParent
    {
        private string checking;// fields
      //  private string streamBank;
      //  private int lineNumber;
      //  private string line;


        public CheckingAcc(string checking) : base("Scrooge McDuck", "SAM US SAVINGS BANK", 233451, 0, 0, 0)//constructors
        {
            this.checking = checking;
            //this.streamBank = "C:/Documents/visual studio 2015/Projects/Key2success";
            //this.lineNumber = 0;
            //this.line = line;
        }
        public void Typeaccount()//created this method to let user know what their overall balnace is and the type of a account they had
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
          //  }All things that are commented out were attempts to to get my streamwriter to work without success I will have to get help to understand the process more because I tried it this way and also I made it a class and tried it I believe Im missing one piece to this but I just can't figurew it out
        }

        

    }


