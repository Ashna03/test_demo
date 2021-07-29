using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public interface IApprovingAuthority
    {
        bool Approve(String msg);

    }

    public class SavingsAccount
    {
        public int Balance;
        private readonly IApprovingAuthority Approver;
        public SavingsAccount(int amount, IApprovingAuthority Approver)
        {
            this.Approver = Approver;
            Balance = amount;
        }

        public void deposit(int value)
        {
            if (value <= 0)
                throw new ArgumentException("Deposit Amount Must be Positive : {value}");
            if (Approver.Approve("Please Approve"))
            {
                Balance += value;
            }

        }

        public bool withdraw(int value)
        {
            if (value > Balance)
            {

                throw new ArgumentException("Withdraw Amount cannot be higher than current balance : {value}");
            }

            Balance -= value;
            return true;
        }

    }
}
