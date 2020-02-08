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

        public void Deposit(double amt) 
        {
            _balance = _balance + amt;
        }

        public void Withdraw(double amt) 
        {
            // _balance = _balance - withdraw; 
             double _calBal = _balance - amt;
              if (_calBal < 500) 
            {
                Console.WriteLine("Can not withdraw amt...min bal is Rs - 500 require");
                return;
            }
            
                _balance = _balance - amt;
           
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
     

    }
}
