using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key2success

{
    class CheckingAcc : MoneyParent
    {
        private double overallBalance1;


        protected double userinput1;


        protected double Userinput1
        {
            get { return this.Userinput1; }
            set { this.Userinput1 = value; }
        }
       
        public CheckingAcc(double overallBalance1, double userinput1) : base("Scrooge McDuck", "SAM US SAVINGS BANK", 0)
        {
            this.overallBalance1=overallBalance1;
            this.userinput1 = userinput1;
        }

        public void PutIn()
        {
            Console.WriteLine("How much will you deposit into your Checking account Mr. McDuck");
            double userinput1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Checking account total is = " +"$"+ userinput1);
        }
        public void Cashin()
        {
            this.PutIn();
            return;
        }
        public double Takeaway1()
        {
            Console.WriteLine("How much would you like to withdraw from your Checking account");
            userinput1 = int.Parse(Console.ReadLine());
            return userinput1;
        }

        public void Itsgone()
        {
            this.Takeaway1();
            
        }
        public void OverallBalance1()
        {
            double Takeaway1 = userinput1;
            Console.WriteLine("You have now deducted: " + "$" + Takeaway1);
            Takeaway1 = int.Parse(Console.ReadLine());
            return;
        }
        public void Lotal1()
        {
            this.OverallBalance1();
        }

    }


}


