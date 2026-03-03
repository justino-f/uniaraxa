//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Receba três números inteiros diferentes e mostre o maior deles.
using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira três valores inteiros. (X Y Z): ");
    var v = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    Console.WriteLine($"Maior: {v.Max()}");
  }
}
