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
                    myBank[i].GenarateAccountNumber();
                    break;
                }
            }
        }

        public void DeleteAccount (int accountNumber)
        {
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i] = null;
                    break;
                }
            }

        }
        public void Transaction (int choice, double amount, int accountNumber, Account receiver)
        {
            switch(choice)
            {
                case 1:
                    
                    for (int i = 0; i < myBank.Length; i++)
                        {
                            if (myBank[i].AccountNumber == accountNumber) 
                                {
                                    myBank[i].Deposit(amount);
                                    break;
                                }
                         }
                    break;
                case 2:
                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i].AccountNumber == accountNumber) 
                        {
                            myBank[i].Withdraw(amount);
                            break;
                        }
                    }
                    break;
                case 3:

                    int transfer = 0;
                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i] == receiver) 
                        {
                            transfer = i;
                            break;
                        }

                    }

                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i].AccountNumber == accountNumber) 
                        {
                            myBank[i].Transfer(amount, myBank[transfer]);
                            break;
                        }
                    }
                    break;
                
                default:
                    break;
            }
        }

        public void PrintAccountDetails ( )
        {
          for (int i = 0; i < myBank.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + myBank[i].AccountName);      
            }
            Console.WriteLine("Insert Account Serial No. If You Further Want To See The Full Information Of An Account.");
            int choice = Convert.ToInt32(Console.ReadLine());
            myBank[choice - 1].ShowAccountInformation();
        }

        }
        
    }

