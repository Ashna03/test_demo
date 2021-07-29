using System;

namespace CoreBankLogic2
{
    public abstract class Account
    {
        public string EmpName { get; set; }
        protected int AccId { get; set; }
        public abstract Account Create_Acc(string name, double balance);
        public abstract bool Delete();
    }

    public class SavingsAccount : Account
    {
        public double Balance { get; private set; }

        public override Account Create_Acc(string name, double balance)
        {
            
            EmpName = name;
            Balance = balance;
            AccId = Guid.NewGuid().GetHashCode();                   //convert guid to int
            Console.WriteLine($"Account Created Successfully for {EmpName} with Account Id: {AccId}");
            return this;

        }
        public double Credit(double Amount)
        {
           
            Balance += Amount;
            return Balance;
        }


        public double Debit(double Amount)
        {
            Balance -= Amount;
            return Balance;
        
        }
        public override bool Delete()
        {
            Console.WriteLine("Do you want to Delete this Account : Y/N");
            string ch = Console.ReadLine();
            if (ch == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
