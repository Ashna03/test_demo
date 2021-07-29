using System;


namespace BankCoreLogic
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
            //Account account = new SavingsAccount();
            EmpName = name;
            Balance = balance;
            AccId = Guid.NewGuid().GetHashCode();                   //convert guid to int
            Console.WriteLine($"Account Created Successfully for {EmpName} with Account Id: {AccId}");
            return this;

        }
        public double Credit(double Amount) 
        {
            //Console.WriteLine("Enter the Amount to be credited:");
            //double Amt = Convert.ToDouble(Console.ReadLine());
            Balance += Amount;
            return Balance;
        }
        

        public double Debit(double Amount)
        {
            Console.WriteLine("Enter the amount to be Debitted");
            double Deb = Convert.ToDouble(Console.ReadLine());
            if (Balance > Deb)
            {
                Console.WriteLine("The Amount has been Debitted");
                return Deb;
            }
            else
            {
                Console.WriteLine("The Account Balance is too Low!!");
                return 0;
            }
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
