//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Crie um programa que some de 1 a 100 usando While.
using System;

internal class Program
{
  static void Main(string[] args)
  {
    int i = 0;
    while (i < 100)
    {
      i++;
      Console.Write($"{i} ");
    }
  }
}
