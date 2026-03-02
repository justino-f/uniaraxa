using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira os valores de X e Y. (x y): ");
    var v = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    Console.WriteLine($"Soma: {v[0] + v[1]} | Subtração: {v[0] - v[1]} | Multiplicação: {v[0] * v[1]} | Divisão: {(double) v[0] / v[1]}");
  }
}