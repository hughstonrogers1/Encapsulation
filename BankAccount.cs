﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance;

        public void Deposit(double amount)
        {
            //Console.WriteLine($" {}");
            _balance = amount;
        }

        public double GetBalance()
        {
            return _balance;
        }

    }
}
