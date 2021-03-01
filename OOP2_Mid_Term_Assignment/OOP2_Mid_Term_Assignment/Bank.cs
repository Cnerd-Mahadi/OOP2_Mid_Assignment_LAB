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
                    Console.WriteLine("Enter Your Address_");
                    Console.WriteLine("Road No, House No, City, Country -");
                    myBank[i].Address.RoadNo = Console.ReadLine();
                    myBank[i].Address.HouseNo = Console.ReadLine();
                    myBank[i].Address.City = Console.ReadLine();
                    myBank[i].Address.Country = Console.ReadLine();
                    Console.WriteLine("New Account Created..");
                    myBank[i].ShowAccountInformation();
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
                    Console.WriteLine("Account Deleted..");
                    break;
                }
            }

        }
        public void Transaction (int choice, int senderAccountNumber, int amount)
        {
            switch(choice)
            {
                case 1:
                    
                    for (int i = 0; i < myBank.Length; i++)
                        {
                            if (myBank[i].AccountNumber == senderAccountNumber) 
                                {
                                    myBank[i].Deposit(amount);
                                    break;
                                }
                         }
                    break;
                case 2:
                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i].AccountNumber == senderAccountNumber) 
                        {
                            myBank[i].Withdraw(amount);
                            break;
                        }
                    }
                    break;
                case 3:

                    Console.WriteLine("Enter Your Receiver Account Number :");
                    int receiverAccountNumber = Convert.ToInt32(Console.ReadLine());
                    int transfer = 0;
                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i].AccountNumber == receiverAccountNumber) 
                        {
                            transfer = i;
                            break;
                        }

                    }

                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i].AccountNumber == senderAccountNumber) 
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
            for (int i = 0; myBank[i] != null; i++)
              {
                  Console.WriteLine((i + 1) + ". " + myBank[i].AccountName);      
              }
              Console.WriteLine("Insert Account Serial No. If You Further Want To See The Full Information Of An Account...");
              int choice = Convert.ToInt32(Console.ReadLine());
              myBank[choice - 1].ShowAccountInformation();
        }

        }
        
    }

