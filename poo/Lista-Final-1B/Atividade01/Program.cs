using System;
namespace Atividade01;

internal class Program
{
  static void Main(string[] args)
  {
    Aluno aluno = new Aluno();
    aluno.ReceberDados();
    aluno.ImprimirNotaFinal();
    aluno.CalcularNotaFinal();
  }
}