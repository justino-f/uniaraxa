using System;
namespace Atividade02;

internal class Program
{
  static void Main(string[] args)
  {
    ContaBancaria nubank = new ContaBancaria();
    nubank.ReceberDados();
    nubank.Depositar(1000);
    nubank.Sacar(1000);
  }
}