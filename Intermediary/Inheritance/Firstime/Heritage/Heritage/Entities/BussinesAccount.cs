using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage.Entities
{
    internal class BussinesAccount : Account
    {
        public double LoanLimit { get; set; }


        public BussinesAccount() { }

        public BussinesAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void loan(double ammout)
        {
            if(ammout <= LoanLimit)
            Balance += ammout;
        }
    }
}
