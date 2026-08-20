namespace Atividade04;

public class CalculadoraDeSalario
{
  private string NomeFuncionario;
  private double SalarioBase;
  private double SalarioFinal;

  public void ReceberDados()
  {
    Console.Write("Nome do Funcionário: ");
    this.NomeFuncionario = Console.ReadLine();
    Console.Write("Salário Base: ");
    this.SalarioBase = double.Parse(Console.ReadLine());
  }

  public void CalcularAumento(double percentual)
  {
    double valorAumentado = (this.SalarioBase * percentual) / 100.0;
    this.SalarioFinal = this.SalarioBase + valorAumentado;
  }

  public void CalcularDesconto(double percentual)
  {
    double valorDescontado = (this.SalarioFinal * percentual) / 100.0;
    this.SalarioFinal -= valorDescontado;
  }

  public void MostrarSalario()
  {
    string output = $"""
    Nome: {this.NomeFuncionario}
    Salário Base: {this.SalarioBase}
    Salário Final: {this.SalarioFinal}
    """;
    Console.WriteLine(output);
  }
}