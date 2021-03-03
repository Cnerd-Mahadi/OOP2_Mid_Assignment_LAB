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
            int flag = 0;
            for (int i = 0; i < myBank.Length; i++)
            {
                if (myBank[i] == null)
                {
                    myBank[i] = account;
                    myBank[i].AutoAcoountNumberGenarator();
                    Console.WriteLine("Address :");
                    Console.WriteLine("Road No -");
                    myBank[i].Address.RoadNo = Console.ReadLine();
                    Console.WriteLine("House No -"); 
                    myBank[i].Address.HouseNo = Console.ReadLine();
                    Console.WriteLine("City -"); 
                    myBank[i].Address.City = Console.ReadLine();
                    Console.WriteLine("Country -");
                    myBank[i].Address.Country = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("_New Account Created_");
                    flag = 1;
                    myBank[i].ShowAccountInformation();
                    break;
                }
                
            }
           if (flag == 0)
            {
                Console.WriteLine("Sorry Account Couldnt Be Created!");
            }
        }

        public void DeleteAccount (int accountNumber)
        {
            int flag = 0;
            for (int i = 0; myBank[i] != null; i++)
            {
                if (myBank[i].AccountNumber == accountNumber)
                {
                    myBank[i] = null;
                    Console.WriteLine("Account Deleted Successfully!");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Sorry Account Couldnt Be Deleted!");
            }
        }
        public void Transaction (int choice, int fromAccountNumber, double amount)
        {
            switch(choice)
            {
                case 1:
                    
                    for (int i = 0; i < myBank.Length; i++)
                        {
                            if (myBank[i].AccountNumber == fromAccountNumber) 
                                {
                                    myBank[i].Deposit(amount);
                                    Console.WriteLine("Money Deposited To Account No. {0} || Amount : {1}", myBank[i].AccountNumber, amount);
                                    break;
                                }
                         }
                    break;
                case 2:
                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i].AccountNumber == fromAccountNumber) 
                        {
                            myBank[i].Withdraw(amount);
                            Console.WriteLine("Money Withdrawn From Account No. {0} || Amount : {1}", myBank[i].AccountNumber, amount);
                            break;
                        }
                    }
                    break;
                case 3:

                    Console.WriteLine("Enter Your Receiver Account Number :");
                    int receiverAccountNumber = Convert.ToInt32(Console.ReadLine());
                    int iReceiver = 0;
                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i].AccountNumber == receiverAccountNumber) 
                        {
                            iReceiver = i;
                            break;
                        }

                    }

                    for (int i = 0; i < myBank.Length; i++)
                    {
                        if (myBank[i].AccountNumber == fromAccountNumber) 
                        {
                            myBank[i].Transfer(amount, myBank[iReceiver]);
                            Console.WriteLine("Money Transfered From Account No. {0} To Account No. {1} || Amount : {2}", myBank[i].AccountNumber, myBank[iReceiver].AccountNumber , amount);
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
                  Console.WriteLine((i + 1) + "--- " + myBank[i].AccountName);      
              }
              Console.WriteLine("Insert Account Serial No. If You Further Want To See The Full Information Of An Account...");
              int choice = Convert.ToInt32(Console.ReadLine());
              myBank[choice - 1].ShowAccountInformation();
        }

        }
        
    }

