/*
using System;
using System.Globalization;

class Produto {
    private string _nome;
    private double _preco;
    private int _quantidade;

    // Construtor
    public Produto(string nome, double preco, int quantidade) {
        _nome = nome;
        _preco = preco;
        _quantidade = quantidade;
    }

    // Properties
    public string Nome {
        get { return _nome; }
        set {
            if (value != null && value.Length > 3){
                _nome = value;
            }
        }
    }

    public double Preco {
        get { return _preco; }
    }

    public int Quantidade {
        get { return _quantidade; }
    }

    public double ValorTotalEmEstoque() {
        return _quantidade * _preco;
    }

    public void AdicionarProdutos(int quantidade) {
        _quantidade += quantidade;
    }

    public void RemoverProdutos(int quantidade) {
        _quantidade -= quantidade;
    }

    // Sobreposição
    public override string ToString() {
        return _nome 
        + ", $ " 
        + _preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", "
        + _quantidade
        + " unidades, Total: $ "
        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}

class Program {
    static void Main(string[] args) {
        Produto produto;
        produto = new Produto("TV", 500.0, 10);
        produto.Nome = "T";
        Console.WriteLine(produto.Nome);
        Console.WriteLine(produto.Preco);
        Console.WriteLine(produto.Quantidade);
    }
}
*/