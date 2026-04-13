using System;

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto();

        Console.WriteLine("Entre os dados do produto:");
        Console.Write("Nome: ");
        produto.Nome = Console.ReadLine();

        Console.Write("Preço: ");
        produto.Preco = double.Parse(Console.ReadLine());

        Console.Write("Quantidade no estoque: ");
        produto.Quantidade = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDados do produto: " + produto);

        Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
        int qtd = int.Parse(Console.ReadLine());
        produto.AdicionarProdutos(qtd);

        Console.WriteLine("Dados atualizados: " + produto);

        Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
        qtd = int.Parse(Console.ReadLine());
        produto.RemoverProdutos(qtd);

        Console.WriteLine("Dados atualizados: " + produto);
    }
}