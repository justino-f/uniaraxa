using System;
namespace Atividade02;

public class ContaBancaria
{
  private string NumeroConta;
  private string NomeTitular;
  private double Saldo;

  public void ReceberDados()
  {
    Console.Write("Insira o número da conta e nome do titular. (X nome): ");
    var s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
    this.NumeroConta = s[0];
    this.NomeTitular = s[1];
    MostrarSaldo();
  }

  public void Depositar(double valor)
  {
    this.Saldo += valor;
    MostrarSaldo();
  }

  public void Sacar(double valor)
  {
    if (valor <= this.Saldo) this.Saldo -= valor;
    else Console.WriteLine("Operação inválida!");
    MostrarSaldo();
  }

  public void MostrarSaldo()
  {
    Console.WriteLine($"Saldo Atual: {this.Saldo}");
  }
}