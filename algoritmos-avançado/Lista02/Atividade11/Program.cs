//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Leia um número e mostre se ele é positivo, negativo ou zero.
using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira um número inteiro: ");
    int X = int.Parse(Console.ReadLine()!);
    if (X > 0) Console.WriteLine("Positivo!");
    else if (X < 0) Console.WriteLine("Negativo!");
    else Console.WriteLine("Zero!");
  }
}
