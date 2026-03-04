//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Leia 10 números e mostre quantos são pares e quantos são ímpares.
using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira 10 números inteiros. (X Y Z etc.): ");
    var v = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    int pares = 0;
    int impares = 0;
    for (int i = 0; i < v.Length; i++)
    {
      if (v[i] % 2 == 0) pares++;
      else impares++;
    }
    Console.WriteLine($"Pares: {pares} | Ímpares: {impares}");
  }
}