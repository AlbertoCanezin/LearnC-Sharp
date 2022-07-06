/*
using System;
using System.Globalization;

public class Controller
{
    public int Conta {get; private set;}
    public string Nome {get; private set;}
    public double Saldo {get; set;}

    // Construtor 
    public Controller(int conta, string nome, double saldo) {
        Conta = conta;
        Nome = nome;
        Saldo = saldo;
    }

    public Controller(int conta, string nome) {
        Conta = conta;
        Nome = nome;
    }
}

public class Program
{
    static void Main(string[] args) {
        Controller user;

        Console.Write("Entre com o número da conta: ");
        int conta = int.Parse(Console.ReadLine());
        Console.Write("Entre com o titular da conta: ");
        string titular = Console.ReadLine();
        
        Console.Write("Haverá deposito inicial? (s/n)");
        char options = char.Parse(Console.ReadLine());

        if (options == 's' || options == 'S') {
            double deposito = double.Parse(Console.ReadLine());
            user = new Controller(conta, titular, deposito);
        }
        else {
            user = new Controller(conta, titular);
        }
        Console.WriteLine("Dados da conta:");
        Console.WriteLine($"Conta {user.Conta}, titular: {user.Nome}, Saldo: $ {user.Saldo}");

        Console.Write("Entre com o valor de deposito: ");
        user.Saldo += double.Parse(Console.ReadLine());
        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine($"Conta {user.Conta}, titular: {user.Nome}, Saldo: $ {user.Saldo}");

        Console.Write("Entre com o valor de saque: ");
        user.Saldo -= double.Parse(Console.ReadLine());
        Console.WriteLine("Dados da conta atualizados:");
        Console.WriteLine($"Conta {user.Conta}, titular: {user.Nome}, Saldo: $ {user.Saldo}");
    }
}
*/