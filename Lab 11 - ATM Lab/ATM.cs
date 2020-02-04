using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11___ATM_Lab
{
    class ATM
    {
        Account currentAccount = null;
        List<Account> accounts = new List<Account>();
        
        public void Register(string userName, string password)
        {
            accounts.Add(new Account(userName, password));
        }

        public void LogOut()
        {
            if (currentAccount != null)
            {
                currentAccount = null;
                Console.WriteLine("You logged out");
            }
            else
            {
                Console.WriteLine("Nobody is logged in so you can't log out");
            }
        }

        public void CheckBalance()
        {
            Console.WriteLine(currentAccount.Balance);
        }

        public void Deposit(int num)
        {
            currentAccount.Balance += num;
        }
        
        public void WithDraw(int num)
        {
            if (num > currentAccount.Balance)
            {
                Console.WriteLine("Error, withdrawl exceeded your balance.");
            }
            else
            {
                currentAccount.Balance -= num;
            }
            CheckBalance();
        }

        public void LogIn(string username, string password)
        {
            if(currentAccount == null)
            {
                foreach(var account in accounts)
                {
                    if (account.Name == username && account.Password == password)
                    {

                        currentAccount = account;
                        Console.WriteLine("You have logged in");
                    }
                   
                }
            }
            else
            {
                Console.WriteLine("Error! Looks like someone else is logged in");
            }
        }
    }
}
