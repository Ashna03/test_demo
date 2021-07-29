using System;
using BankCoreLogic;



namespace BankUI
{
    class Program
    { 
        static void Main(string[] args)
        {
            SavingsAccount sav = new SavingsAccount();
            
            Console.WriteLine("Enter the name of the Account Holder");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Balance in account");
            double balance = Convert.ToDouble(Console.ReadLine());

            Account temp=sav.Create_Acc(name,balance);
            sav.Credit(1000);
            sav.Debit(500);

        }

        public static void DeleteAccount(SavingsAccount sav) 
        {
            bool DelAcc = sav.Delete();
            if (DelAcc)
            {
                sav = null;
                Console.WriteLine("Account has been successfully deleted");
            }
            else 
            {
                Console.WriteLine($"Your Account with Account Id {AccId} exists");
            }
        }
    }
}
