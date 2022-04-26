using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aufgabe04_3
{
    public class BankAccount
    {

        public BankAccount()
        {
            Balance = 0;
        }

        public double Balance { get; private set; }
        
        public bool Deposit(double amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            else
            {
                Balance += amount;
                return true;
            }

        }

        public bool Withdraw(double amount)
        {
            if (amount <= 0)
            {
                return false;
            }

            else
            {
                Balance -= amount;
                return true;
            }
        }
            
    }
}
