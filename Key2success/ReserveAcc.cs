using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key2success
{
    class ReserveAcc : MoneyParent
    {

        private double overallBalance3;
        protected double userinput1;

        protected double Userinput1
        {
            get { return this.Userinput1; }
            set { this.Userinput1 = value; }
        }
        public ReserveAcc(double overallBalance3,double userinput1) : base("Scrooge McDuck", "SAM US SAVINGS BANK", 0)
        {
            this.overallBalance3 = overallBalance3;
            this.userinput1 = userinput1;
            
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
        public double Takeaway3()
        {
            Console.WriteLine("How much would you like to withdraw from your Reserve account");
            userinput1 = int.Parse(Console.ReadLine());
            return userinput1;
        }
        public void Itsgone()
        {
            this.Takeaway3();           
        }
        public void OverallBalance3()
        {
            double Takeaway3 = userinput1;
            Console.WriteLine("You have now deducted: " + "$" + Takeaway3);
            Takeaway3= int.Parse(Console.ReadLine());
            return;
        }
        public void Lotal3()
        {
            this.OverallBalance3();
        }

    }
}