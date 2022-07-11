using System;

public class Client
{
    public string Name { get; set; }
    public string Email { get; set; }

    
    public override bool Equals(object obj)
    {       
        if (!(obj is Client))
        {
            return false;
        }
        Client other = obj as Client;
        return Email.Equals(other.Email);
    }
    
    public override int GetHashCode()
    {
        return Email.GetHashCode();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Client a = new Client { Name = "Maria", Email = "maria@email.com" };
        Client b = new Client { Name = "João", Email = "joao@email.com" };

        Console.WriteLine(a.Equals(b));
        Console.WriteLine(a.GetHashCode());
        Console.WriteLine(b.GetHashCode());
    }
}