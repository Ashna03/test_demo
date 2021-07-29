using System;


namespace LabOops
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SavingAccount saccount = new SavingAccount("Mary",1000);
            Console.WriteLine($"This account belongs to username {saccount.AccName}");
            Console.WriteLine("Action : Debitting from Account");
            saccount.Debit(2000);
            Console.WriteLine($"The current balance in account is {saccount.AccBal}");

            Console.WriteLine("Action : Crediting to Account");
            saccount.Credit(3000);
            Console.WriteLine($"The current balance in account is {saccount.AccBal}");

            Console.WriteLine("Action : Debitting from Account");
            saccount.Debit(1000);
            Console.WriteLine($"The current balance in account is {saccount.AccBal}");
        }
    }
}
