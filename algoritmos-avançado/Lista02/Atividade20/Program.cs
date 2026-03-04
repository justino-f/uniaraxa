//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Leia um número e mostre seu dobro, triplo e raiz quadrada.
using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira um número inteiro: ");
    int X = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Dobro: {X * 2} | Triplo: {X * 3} | Raiz Quadrada: {Math.Sqrt(X)}");
  }
}