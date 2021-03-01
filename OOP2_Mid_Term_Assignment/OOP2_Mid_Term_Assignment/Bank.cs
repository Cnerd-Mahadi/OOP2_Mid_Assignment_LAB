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
           for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    break;
                }
            }
        }

        public void DeleteAccount (int accountNumber)
        {
           /* for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i]. == null) // Account number check is unfinished here
                {
                    myBank[i] = account;
                    break;
                }
            }

            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null) // If accountnumber and myBank[i].acn is equal or not
                {
                    myBank[i] = null;
                    break;
                }
            }*/


        }
        public void Transaction (int amount, Account receiver)
        {
            switch(amount)
            {
                case 1:
                    /* for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i]. == null) // Account number check is unfinished here
                {
                    myBank[i] = account;
                    break;
                }
            }*/

                    break;
                case 2:
                    /* for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i]. == null) // Account number check is unfinished here
                {
                    myBank[i] = account;
                    break;
                }
            }*/
                    break;
                case 3:
                    /* for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i]. == null) // Account number check is unfinished here
                {
                    myBank[i] = account;
                    break;
                }
            }*/
                    break;
            }
        }

        public void PrintAccountDetails ( )
        {
              /* for (int i = 0; i < myBank.Length; i++)
            {
                 // Show all the accounts available and add ShowAccount info
                }
            } */

        }
        
    }
}
