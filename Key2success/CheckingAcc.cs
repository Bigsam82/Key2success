using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key2success
{
    class CheckingAcc
    {
        private int withDrawfunds;
        private int depositFunds;


        public int DepositFunds
        {
            get { return this.DepositFunds; }
            set { this.DepositFunds = value; }
        }

        public int WithDrawfunds
        {
            get { return this.WithDrawfunds; }
            set { this.WithDrawfunds = value; }
        }
        public CheckingAcc(int withDrawfunds, int depositFunds)
        {
            this.withDrawfunds = withDrawfunds;
            this.depositFunds = depositFunds;

        }
    }
}
