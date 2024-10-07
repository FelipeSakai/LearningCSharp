using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heritage.Entities
{
     class Account
    {
        public int Number { get; private set; }

        public string Holder { get; private set; }

        public double Balance { get; protected set; }


        public Account() { }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public void Withdraw(double ammout)
        {
            Balance -= ammout;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}
