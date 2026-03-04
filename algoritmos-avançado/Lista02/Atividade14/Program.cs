//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Leia um número inteiro e mostre todos os pares de 0 até ele.
using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira um número inteiro: ");
    int X = int.Parse(Console.ReadLine()!);
    for (int i = 0; i <= X; i++)
    {
      if (i % 2 == 0) Console.WriteLine(i);
    }
  }
}