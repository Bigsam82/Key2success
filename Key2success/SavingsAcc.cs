using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key2success
{
    class SavingsAcc : MoneyParent
    {
        private double overallBalance2;
        protected double userinput1;

        protected double Userinput1
        {
            get { return this.Userinput1; }
            set { this.Userinput1 = value; }
        }
        
        public SavingsAcc(double overallBalance2, double userinput1) : base("Scrooge McDuck", "SAM US SAVINGS BANK", 0)
        {
            this.overallBalance2 = overallBalance2;
            this.userinput1 = userinput1;

        }
        public void PutIn2()
        {
            Console.WriteLine("How much will you deposit into your Savings account Mr. McDuck");
            double userinput1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Savings account total is = " + "$" + userinput1);
        }
        public void Cashin3()
        {
            this.PutIn2();
            return;
        }
        public double Takeaway2()
        {
            Console.WriteLine("How much would you like to withdraw from your Reserve account");
            userinput1 = int.Parse(Console.ReadLine());
            return userinput1;
        }

        public void Itsgone()
        {
            this.Takeaway2();
        }
        public void OverallBalance2()
        {
            double Takeaway2 = userinput1;
            Console.WriteLine("You have now deducted: " +"$"+ Takeaway2);
            Takeaway2 = int.Parse(Console.ReadLine());
            return;
        }
        public void Lotal2()
        {
            this.OverallBalance2();
        }
    }
}