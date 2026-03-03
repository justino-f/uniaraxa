//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Leia um número e mostre sua tabuada de 1 a 10 usando for.
using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira um número inteiro: ");
    int X = int.Parse(Console.ReadLine()!);
    for (int i = 1; i <= 10; i++)
    {
      Console.WriteLine($"{X} X {i} = {X * i}");
    }
  }
}
