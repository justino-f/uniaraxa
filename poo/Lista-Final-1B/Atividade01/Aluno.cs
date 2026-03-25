using System;
namespace Atividade01;

public class Aluno
{
  private string RA;
  private string Nome;
  private double NotaB1;
  private double NotaB2;
  private double NotaFinal;
  private double NotaMedia;
  private double NotaP3;

  public void CalcularMedia()
  {
    this.NotaMedia = (NotaB1 + NotaB2) / 2.0;
  }

  public void CalcularNotaFinal()
  {
    CalcularMedia();
    this.NotaFinal = this.NotaB1 + this.NotaB2;
    if (this.NotaFinal > 4 && this.NotaFinal < 14)
    {
      this.NotaP3 = 14 - this.NotaMedia;
      Console.WriteLine($"Recuperação! Nota necessária: {this.NotaP3}");
    } 
    else if (this.NotaFinal >= 14) Console.WriteLine("Aprovado!");
    else Console.WriteLine("Reprovado!");
  }

  public void ImprimirNotaFinal()
  {
    CalcularMedia();
    Console.WriteLine($"Nota necessária da P3: {this.NotaFinal}");
  }

  public void ReceberDados()
  {
    Console.Write("Insira o nome e RA do aluno. (Nome RA): ");
    var s = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
    this.Nome = s[0];
    this.RA = s[1];
    Console.Write("Insira a nota do 1° e 2° bimestre. (X Y): ");
    var n = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
    this.NotaB1 = n[0];
    this.NotaB2 = n[1];
  }
}