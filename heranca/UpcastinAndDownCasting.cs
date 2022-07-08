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
}

public class Heranca
{
    public static void Main(string[] args)
    {
        Account acc = new Account(1001, "Zé", 0.0);
        BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

        // UPCASTING
        Account acc1 = bacc;
        Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.00);
        Account acc3 = new SavingAccount(1004, "Anna", 0.0, 0.01);

        // DOWNCASTING (Usamo apenas quando muito necessário)
        BusinessAccount acc4 = (BusinessAccount)acc2;
        // Podemos realizar validações para evitar erros
        if (acc3 is BusinessAccount) 
        {
            // Sintaxe alternativa para o casting
            BusinessAccount acc5 = acc3 as BusinessAccount;
            acc5.Loan(200.0);
            Console.WriteLine("Loan!");
        }
        if (acc3 is SavingAccount)
        {
            SavingAccount acc5 = (SavingAccount)acc3;
            acc5.UpdateBalance();
            Console.WriteLine("Update!");
        }
    }
}
*/
