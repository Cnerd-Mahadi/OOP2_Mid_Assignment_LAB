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
        static int next = 3300; 
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

        public void GenarateAccountNumber ()
        {
            this.accountNumber = next;
            next++;
        }

        public int AccountNumber
        {
            get { return this.accountNumber;}
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
            Console.WriteLine("Account Information :");
            Console.WriteLine("Account Name : " + this.accountName);
            Console.WriteLine("Account Name : " + this.accountNumber);
            Console.WriteLine("Account Name : " + this.balance);
            Console.WriteLine("Account Name : " + this.address.GetAddress());

        }
    }
}
