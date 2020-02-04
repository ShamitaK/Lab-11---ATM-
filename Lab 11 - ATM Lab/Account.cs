using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_11___ATM_Lab
{
    class Account : ATM
    {
        private string name;
        private string password;
        private int balance;

        //properties
        public string Name { get { return name; } set { name = value; } }
        public string Password { get { return password; } set { password = value; } }
        public int Balance { get { return balance; } set { balance = value; } }

        public Account()
        {

        }

        public Account(string _name, string _password)
        {
            name = _name;
            password = _password;
            balance = 0;
        }
    }
}
