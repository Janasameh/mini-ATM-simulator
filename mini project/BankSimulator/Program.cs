using System;
using System.Collections.Generic;

class Account
{
    public string Name;
    public int Balance;

    public Account(string name)
    {
        this.Name = name;
        Balance = 0;
    }

    public void Deposit(int value)
    {
        this.Balance += value;
    }

    public void Withdraw(int value)
    {
        if (value <= this.Balance)
        {
            this.Balance -= value;
        }
        else
        {
            Console.WriteLine("You don't have enough balance in your account for this transaction");
        }
    }

    public int Show()
    {
        return this.Balance;
    }

    public static void Menu(Account currentAccount)
    {
        Console.WriteLine("====== Bank Menu ======");
        if (currentAccount == null)
        {
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Select Account");
        }
        else
        {
            Console.WriteLine($"Welcome, {currentAccount.Name}!");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Withdraw");
            Console.WriteLine("5. Show Balance");
            Console.WriteLine("6. Exit");
        }
    }
}

class Program
{
    static void Main()
    {
        List<Account> accounts = new List<Account>();
        Account currentAccount = null;

        while (true)
        {
            Account.Menu(currentAccount);

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Please write your name");
                string inputName = Console.ReadLine();
                Account ACC1 = new Account(inputName);
                currentAccount = ACC1;
                accounts.Add(ACC1);
            }
            else if (choice == "2")
            {
                Console.WriteLine("Enter account name:");
                string ACCname = Console.ReadLine();

                foreach (Account account in accounts)
                {
                    if (account.Name == ACCname)
                    {
                        currentAccount = account;
                        break;
                    }
                }

                if (currentAccount == null)
                {
                    Console.WriteLine("Account not found");
                }
            }
            else if (choice == "3")
            {
                if (currentAccount != null)
                {
                    Console.WriteLine("Please deposit money");
                    int value = int.Parse(Console.ReadLine());
                    currentAccount.Deposit(value);
                    Console.WriteLine(currentAccount.Show());
                }
                else
                {
                    Console.WriteLine("Please select account");
                }
            }
            else if (choice == "4")
            {
                if (currentAccount != null)
                {
                    Console.WriteLine("Please withdraw money");
                    int value = int.Parse(Console.ReadLine());
                    currentAccount.Withdraw(value);
                    Console.WriteLine(currentAccount.Show());
                }
                else
                {
                    Console.WriteLine("Please select account");
                }
            }
            else if (choice == "5")
            {
                if (currentAccount != null)
                {
                    Console.WriteLine(currentAccount.Show());
                }
                else
                {
                    Console.WriteLine("Please select account");
                }
            }
            else if (choice == "6")
            {
                break;
            }
        }
    }
}  