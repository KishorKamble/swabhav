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
            Account acc1 = new Account("K12345", "Kishor", 200d);
            Console.WriteLine("Before Deposite");
            PrintInfo(acc1);
            acc1.DepositAmt(300);
            Console.WriteLine("After Deposite Rs-300/-");
            PrintInfo(acc1);
                      
            acc1.WithdrawAmt(501);
            Console.WriteLine("After Withdraw Rs-501/-");
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
