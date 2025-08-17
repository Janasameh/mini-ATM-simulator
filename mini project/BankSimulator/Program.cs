using System;

class Account
{
    public string name;
    public int Balance;

/// constructor////
    public  Account( string name)
    {
        this.name=name;
        Balance=0;
    }
    public void deposit( int Balance)
    {
        this.Balance+=Balance;
    }
    public void Withdraw(int value)
    {
          this.Balance-=value;
    }
    public int Show()
    {
        return this.Balance;
    }
}

class Program
{
    static void Main()
    {
      Console.WriteLine(" please write your name");
      string inputName = Console.ReadLine();
      Account ACC1 = new Account(inputName);

while (true)
{
    
Console.WriteLine("1. Deposit");
Console.WriteLine("2. Withdraw");
Console.WriteLine("3. Show Balance");
Console.WriteLine("4. Exit");

    string choice=Console.ReadLine();
 
if (choice == "1")
{
Console.WriteLine(" please deposit money");
int value = int.Parse(Console.ReadLine());
        ACC1.deposit(value);
          Console.WriteLine(ACC1.Show());
 }
  
else if (choice == "2")
 {
Console.WriteLine(" please withraw money");
int value = int.Parse(Console.ReadLine());
        ACC1.Withdraw(value);
          Console.WriteLine(ACC1.Show());
 }
else if (choice == "3")
{
    Console.WriteLine(ACC1.Show());
}
else if (choice == "4")
{
    break; // exit loop
}
}

    }
}