/*
using System;
using System.Globalization;

class Produto {
    public string Nome;
    public double Preco;
    public int Quantidade;

    public double ValorTotalEmEstoque() {
        return Quantidade * Preco;
    }

    public void AdicionarProdutos(int quantidade) {
        Quantidade += quantidade;
    }

    public void RemoverProdutos(int quantidade) {
        Quantidade -= quantidade;
    }

    // Sobreposição
    public override string ToString() {
        return Nome 
        + ", $ " 
        + Preco.ToString("F2", CultureInfo.InvariantCulture)
        + ", "
        + Quantidade
        + " unidades, Total: $ "
        + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
    }
}

class Program {
    static void Main(string[] args) {
        Produto produto;
        produto = new Produto();
        Console.Write("Digite o nome do produto: ");
        produto.Nome = Console.ReadLine();
        Console.Write("Digite o preço do produto: R$ ");
        produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Digite a quantidade do produto: ");
        produto.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine($"Dados do produto: {produto}");

        Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
        int qte = int.Parse(Console.ReadLine());
        produto.AdicionarProdutos(qte);
        Console.WriteLine($"Dados do produto: {produto}");

        Console.Write("Digite o número de produtos a ser removido: ");
        int menosQte = int.Parse(Console.ReadLine());
        produto.RemoverProdutos(menosQte);
        Console.WriteLine($"Dados do produto: {produto}");
    }
}
*/