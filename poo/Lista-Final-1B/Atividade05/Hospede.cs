namespace Atividade05;

public class Hospede
{
  private string Nome;
  private string CPF;
  private string Telefone;

  public void ReceberDados()
  {
    Console.Write("Nome: ");
    this.Nome = Console.ReadLine();
    Console.Write("CPF: ");
    this.CPF = Console.ReadLine();
    Console.Write("Telefone: ");
    this.Telefone = Console.ReadLine();
  }

  public void MostrarDados()
  {
    string output = $"""
    Nome: {this.Nome}
    CPF: {this.CPF}
    Telefone: {this.Telefone}
    """;
    Console.WriteLine(output);
  }

  public void AtualizarTelefone(string novoTelefone)
  {
    this.Telefone = novoTelefone;
  }
}