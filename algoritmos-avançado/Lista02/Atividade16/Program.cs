//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Leia um número e mostre seu fatorial.
using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira um número inteiro: ");
    int X = int.Parse(Console.ReadLine()!);
    for (int i = X - 1; i >= 1; i--)
    {
      X *= i;
    }
    Console.WriteLine($"Fatorial: {X}");
  }
}