namespace Aula04;
using System;

internal class Program
{
  static void Main(string[] args)
  {
    Boletim boletim = new Boletim();
    Console.Write("Aluno: ");
    string nomeAluno = Console.ReadLine()!;
    boletim.aluno.Nome = nomeAluno;
    Console.Write("Disciplina: ");
    string nomeDisciplina = Console.ReadLine()!;
    boletim.disciplina.Nome = nomeDisciplina;
    Console.Write("Professor: ");
    string nomeProfessor = Console.ReadLine()!;
    boletim.professor.Nome = nomeProfessor;
    Console.Write("Insira as notas. (a b c): ");
    var n = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
    boletim.Notas = n;
    Output(boletim);
  }

  static void Output(Boletim boletim)
  {
    double soma = 0;
    Console.Clear();
    Console.WriteLine($"Aluno: {boletim.aluno.Nome}");
    Console.WriteLine($"Disciplina: {boletim.disciplina.Nome}");
    Console.WriteLine($"Professor: {boletim.professor.Nome}\n");
    for (int i = 0; i < 3; i++) 
    {
      Console.WriteLine($"Nota {i + 1}: {boletim.Notas[i]}");
      soma += boletim.Notas[i];
    }
    double media = soma / boletim.Notas.Length;
    Console.WriteLine($"\nMédia: {media}");
    if (media >= 7) Console.WriteLine("Situação: Aprovado");
    else Console.WriteLine("Situação: Reprovado");
  }
}