//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Leia um número e mostre se ele é primo.
using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira um número inteiro: ");
    int X = int.Parse(Console.ReadLine()!);
    int soma = 0;
    for (int i = 1; i <= X; i++)
    {
      if (X % i == 0) soma++;
    }
    if (soma == 2) Console.WriteLine("Primo.");
    else Console.WriteLine("Não primo.");
  }
}