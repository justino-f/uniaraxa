//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Leia dois pontos no plano e calcule a distância entre eles.
using System;

internal class Program
{
  static void Main()
  {
    Console.Write("Insira as coordenadas X e Y. (x1 x2 y1 y2): ");
    var v = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
    Console.WriteLine($"Distância: {Math.Sqrt(Math.Pow(v[1] - v[0], 2) + Math.Pow(v[3] - v[2], 2))}");
  }
}