using System;
using System.Collections.Generic;
using System.Text;

namespace LabOops
{
    public class Account
    {
        public Account(string name)
        {
            AccName = name;
        }
        public string AccName { get; set; }


        protected Guid AccId;
        public int AccBal { get; set; }

        public void CreateAccount(int b) 
        {
            AccBal = b;
        }
        
    }
    public class SavingAccount : Account
    {
        public SavingAccount(string name, int int_bal): base(name)
        {
             AccId = Guid.NewGuid();
            CreateAccount(int_bal);
        }
        public void Credit(int bal)
        {
            Console.WriteLine($"Your current balance is {AccBal}");
            AccBal += bal;
            Console.WriteLine($"Your new balance after credit is {AccBal}");
                
        }
        public void Debit(int amt)
        { 
          if (AccBal > amt)
	      {
            Console.WriteLine($"Your current balance is {AccBal}");
            AccBal -= amt;
            Console.WriteLine($"Your new balance after debit is {AccBal}");

	      }
          else
	      {
             Console.WriteLine("Not Enough Balance ");   
	      }
        }
    }
}
