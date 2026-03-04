//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Leia cinco idades e mostre a media.
using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira cinco idades. (X Y Z etc.): ");
    var v = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
    double soma = 0;
    for (int i = 0; i < v.Length; i++) soma += v[i];
    Console.WriteLine($"Média Simples: {soma / v.Length}");
  }
}