using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Mid_Term_Assignment
{
    class Bank
    {
        private string bankName;
        private Account[] myBank = new Account[10];

        public string BankName 
        {
            get {return this.bankName;}
            set {this.bankName = value;}
        }

        public void AddAccount (Account account)
        {
               
        }

        public void DeleteAccount (int accountNumber)
        {

        }
        public void Transaction (int amount, Account receiver)
        {

        }

        public void PrintAccountDetails ( )
        { 

        }
        
    }
}
