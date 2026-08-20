using System;
namespace Atividade03;

internal class Program
{
  static void Main(string[] args)
  {
   Produto maca = new Produto();
   maca.ReceberDados(); 
   maca.AdicionarEstoque(10);
   maca.RemoverEstoque(11);
   maca.RemoverEstoque(5);
   maca.MostrarProduto();
  }
}