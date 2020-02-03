using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    class Account
    {
        private string _account;
        private string _name;
        private Double _balance;
        private double _deposit;

        public Account(string account,string name,Double balance)
        {
            _account = account;
            _name = account;
            _balance = balance;
            Console.WriteLine("account created ....//////////////////////////////");
        }

        public Account(string account,string name):this(account,name,500)
        {
        }

        public void DepositAmt(double deposit) 
        {
            _balance = _balance + deposit;
        }

        public void WithdrawAmt(double withdraw) 
        {
            // _balance = _balance - withdraw;

            if (_balance < withdraw) 
            {
                Console.WriteLine("Can not withdraw amt...");
            }
            else
            {
                _balance = _balance - withdraw;
            }
        }

        public string AccountNo
        {
            get
            {
                return _account;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double Balance
        {
            get
            {
                return _balance;
            }
        }
        public double Deposit
        {
            get
            {
                return _deposit;
            }
        }


    }
}
