using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Account acc1 = new Account("K12345", "Kishor", 2000d);
            Console.WriteLine("Before Deposite");
            PrintInfo(acc1);
            acc1.Deposit(500);
            Console.WriteLine("After Deposite Rs-500/-");
            PrintInfo(acc1);

            Console.WriteLine("Now Withdrawing Rs-2001/-");

            acc1.Withdraw(2001);
          
            PrintInfo(acc1);


            Account acc2 = new Account("v37645", "Vishal");
            PrintInfo(acc2);
            Console.ReadLine();
        }

        public static void PrintInfo(Account acc)
        {
            Console.WriteLine("Account No - " + acc.AccountNo);
            Console.WriteLine("Name - " + acc.Name);
            Console.WriteLine("Balance - " + acc.Balance);
            Console.WriteLine("");
        }

    }
}
