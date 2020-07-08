using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulationconsol
{
    public class BankAccount

    {
        private double balance = 0;
        //SetBalance=Deposit
        public void SetBalance(double amountToDeposit)
        {
            balance = balance + amountToDeposit;


        }

        public double GetBalance()
        {
            return balance;
        }


    }        
}

