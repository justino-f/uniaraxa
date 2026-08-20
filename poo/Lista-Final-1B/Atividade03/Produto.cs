using System;
namespace Atividade03;

public class Produto
{
  private string CodigoProduto;
  private string NomeProduto;
  private double Preco;
  private int QuantidadeEstoque;

  public void ReceberDados()
  {
    Console.Write("Código: ");
    this.CodigoProduto = Console.ReadLine();
    Console.Write("Nome: ");
    this.NomeProduto = Console.ReadLine();
    Console.Write("Preço: ");
    this.Preco = double.Parse(Console.ReadLine());
    Console.Write("Quantidade: ");
    this.QuantidadeEstoque = int.Parse(Console.ReadLine());
  }

  public void AdicionarEstoque(int quantidade)
  {
    this.QuantidadeEstoque += quantidade;
  }

  public void RemoverEstoque(int quantidade)
  {
    if (quantidade > this.QuantidadeEstoque) Console.WriteLine("Quantidade insuficiente para remover!");
    else this.QuantidadeEstoque -= quantidade;
  }

  public void MostrarProduto()
  {
    string output = $"""
    Código: {this.CodigoProduto}
    Nome: {this.NomeProduto}
    Preço: {this.Preco}
    Quantidade: {this.QuantidadeEstoque}
    """;
    Console.WriteLine(output);
  }
  
}