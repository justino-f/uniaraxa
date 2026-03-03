//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Crie um programa que leia dois números inteiros e mostre a soma, subtração, multiplicação e divisão do primeiro pelo segundo.

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