//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Leia um número e mostre todos os seus divisores.
using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira um número inteiro: ");
    int X = int.Parse(Console.ReadLine()!);
    for (int i = 1; i <= X; i++)
    {
      if (X % i == 0) Console.WriteLine(i);
    }
  }
}