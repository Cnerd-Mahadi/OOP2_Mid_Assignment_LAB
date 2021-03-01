using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Mid_Term_Assignment
{
    class Account
    {
        private int accountNumber;
        private string accountName;
        private double balance;
        private Address address;
        public string AccountName
        {
            get {return this.accountName;}
            set {this.accountName = value;}
        }

        public double Balance
        {
            get {return this.balance;}
            set {this.balance = value;}
        }

        public void Withdraw (double amount)
        {

        }

        public void Deposit (double amount)
        {

        }

        public void Transfer(double amount, Account receiver)
        {
            
        }

        public void ShowAccountInformation()
        {

        }
    }
}
