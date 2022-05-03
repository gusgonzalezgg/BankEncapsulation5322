﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance = 0;

        public void Deposit( double cash )       
        {
            balance += cash;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
