using System;
using CoreBankLogic2;

namespace BankUI2
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
            Account temp = sav.Create_Acc(name, balance);

            // Creditting
            Console.WriteLine("Enter the Amount to be credited:");
            double Amt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("======Crediting Amount to your Account======");
            Console.WriteLine($"The amount credited is {Amt} ");
            double amt = sav.Credit(Amt);
            Console.WriteLine($"The amount in Bank after Credit is {amt}");

            //Debitting
            Console.WriteLine("Do you Want to Debit Amount: Y/N");
            string ans = Console.ReadLine();
            if (ans == "Y")
            {
                Console.WriteLine("Enter the Amount to be Debitted:");
                double deb_Amt = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("======Debitting Amount from your Account======");
                if (sav.Balance > deb_Amt)
                {
                    Console.WriteLine($"The Amount {deb_Amt} has been Debitted");
                    double deb_bal = sav.Debit(deb_Amt);
                    Console.WriteLine($"The amount in Bank after Debit is {deb_bal} ");
                }
                else
                {
                    Console.WriteLine("The Account Balance is too Low!!");

                }
            }
            else
            {
                Console.WriteLine("Thank You for using our Service");
            }

            DeleteAccount(sav);   

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
                Console.WriteLine($"Thank You For Continuing our Service");
            }
        }
    }
}