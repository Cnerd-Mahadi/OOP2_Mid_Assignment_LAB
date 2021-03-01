using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_Mid_Term_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank();
            b1.BankName = "Stay_Humble";
            Console.WriteLine("Welcome To {0} Bank...",b1.BankName);
            bool value = true;            
            while(value)
            {
                Console.WriteLine("What Service Do You Want?");
                Console.WriteLine("1.Add Account\n2.Delete Account\n3.Transaction\n4.Print Account Details\n5.Quit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                case 1:
                    Account a1 = new Account(new Address());
                    Console.WriteLine("Enter Your Account Name :");
                    a1.AccountName = Console.ReadLine();
                    Console.WriteLine("Enter Balance :");
                    a1.Balance = Convert.ToInt32(Console.ReadLine());
                    b1.AddAccount(a1);
                    break;

                case 2:
                    Console.WriteLine("Enter Account Number To Delete :");
                    int deleteAccountNumber = Convert.ToInt32(Console.ReadLine());
                    b1.DeleteAccount(deleteAccountNumber);
                    break;

                case 3:
                    Console.WriteLine("Enter The Transaction Service:\n1.Deposit\n2.Withdraw\n3.Transfer");
                    int c2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter The Amount:");
                    int amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter The Account Number:");
                    int senderAccountNumber = Convert.ToInt32(Console.ReadLine());
                    b1.Transaction(c2, senderAccountNumber, amount);
                    break;
                case 4:
                    Console.WriteLine("These Are All Your Accounts..");
                    b1.PrintAccountDetails();
                    break;
                case 5:
                        value = false;
                        break;
                  default:
                        break;
                }
            }
        }
    }
}
