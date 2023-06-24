using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTasks
{
    internal interface IBanlkAcount
    {
        public abstract double GetBalance();
        public abstract void Withdraw(double amount);
        public abstract void Deposit(double amount);
    }

    internal class SavingAccount : IBanlkAcount
    {
        public double savingbalance;

        public SavingAccount(double savingbalance)
        {
            this.savingbalance = savingbalance;
        }

        public void Deposit(double amount)
        {
            savingbalance = this.savingbalance+amount;
             Console.WriteLine($" after depositing you have {this.savingbalance} OMR  ");
        }

        public double GetBalance()
        {
            return savingbalance;
        }

        public void Withdraw(double amount)
        {
            if (savingbalance < amount)
            {
                Console.WriteLine("You dount have enogh mony");
            }
            else
            {
                Console.WriteLine($" after Withdrawing you have {this.savingbalance - amount} OMR  ");
            }
        }
    }

    internal class CheckingAccount : IBanlkAcount
    {
        public double balance;
        public CheckingAccount(double balance)
        {
            this.balance = balance;
        }

        public void Deposit(double amount)
        {
            balance = this.balance + amount;
            Console.WriteLine($" after depositing you have {this.balance} OMR  ");
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Withdraw(double amount)
        {
            if (balance < amount)
            {
                Console.WriteLine("You dount have enoght mony in your account ");
            }
            else
            {
                Console.WriteLine($" after Withdrawing you have in your account {this.balance - amount} OMR  ");
            }
        }
    }
}
