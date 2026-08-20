namespace Atividade05;

public class Reserva
{
  private string NumeroReserva;
  private int QuantidadeDiarias;
  private double ValorDiaria;
  private double ValorTotal;

  public void ReceberDados()
  {
    Console.Write("Número da Reserva: ");
    this.NumeroReserva = Console.ReadLine();
    Console.Write("Quantidade de Diárias: ");
    this.QuantidadeDiarias = int.Parse(Console.ReadLine());
    Console.Write("Valor da Diária: ");
    this.ValorDiaria = double.Parse(Console.ReadLine());
  }

  public void CalcularTotal()
  {
    this.ValorTotal = this.ValorDiaria * this.QuantidadeDiarias;
  }

  public void AplicarDesconto(double percentual)
  {
    double valorDescontado = (this.ValorTotal * percentual) / 100;
    this.ValorTotal -= valorDescontado;
  }
  public void MostrarReserva()
  {
    string output = $"""
    Número da Reserva: {this.NumeroReserva}
    Quantidade de Diárias: {this.QuantidadeDiarias}
    Valor da Diária: {this.ValorDiaria}
    Valor Total: {this.ValorTotal}
    """;
    Console.WriteLine(output);
  }
}