//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Receba dois números inteiros diferentes e mostre o maior deles.
using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira dois valores inteiros. (X Y): ");
    var v = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    if (v[0] != v[1]) Console.WriteLine($"Maior: {v.Max()}");
    else Console.WriteLine("Iguais.");
  }
}
