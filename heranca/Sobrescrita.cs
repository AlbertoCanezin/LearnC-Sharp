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

    // A palavra virtual no C# diz que pode sobrescrever um método em subclasses
    public virtual void Withdraw(double amount) 
    {
        Balance -= amount + 5;
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

public class SavingAccount : Account
{
    public double InterestRate { get; set; }

    public SavingAccount() {}

    public SavingAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
    {
        InterestRate = InterestRate;
    }

    public void UpdateBalance() 
    {
        Balance += Balance * InterestRate;
    }

    public override void Withdraw(double amount) 
    {
        Balance -= amount;
    }
}

public class Heranca
{
    public static void Main(string[] args)
    {
       Account acc1 = new Account(1001, "Alex", 500.00);
       Account acc2 = new SavingAccount(1002, "Anna", 500.00, 0.01);

       acc1.Withdraw(10.00);
       acc2.Withdraw(10.00);

       Console.WriteLine(acc1.Balance);
       Console.WriteLine(acc2.Balance);
    }
}
*/
