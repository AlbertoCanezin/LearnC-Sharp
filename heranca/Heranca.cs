/*
using System;

public class Account
{
    public int Number { get; protected set; }
    public string Holder { get; protected set; }
    public double Balance { get; protected set; }

    public Account() {}

    public Account(int number, string holder, double balance)
    {
        Number = number;
        Holder = holder;
        Balance = balance;
    }

    public void Withdraw(double amount) 
    {
        Balance -= amount;
    }

    public void Deposit(double amount) 
    {
        Balance += amount;
    }
}

public class BusinessAccount : Account
{
    public double LoanLimit { get; set; }
    
    public BusinessAccount() {}

    // Declarando o construtor, passando as propriedades que serão herdadas
    public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
    {
        LoanLimit = loanLimit;   
    }

    public void Loan(double amount) 
    {
        if (amount <= LoanLimit) {
            Balance += amount;
        }
    }
}

public class Heranca
{
    public static void Main(string[] args)
    {
        BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);
        Console.WriteLine(account.Balance);
    }
}
*/