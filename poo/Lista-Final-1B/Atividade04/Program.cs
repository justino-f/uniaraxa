using System;
namespace Atividade04;

internal class Program
{
  static void Main(string[] args)
  {
    CalculadoraDeSalario renato = new CalculadoraDeSalario();
    renato.ReceberDados();
    renato.CalcularAumento(10);
    renato.CalcularDesconto(3);
    renato.MostrarSalario();
  }
}