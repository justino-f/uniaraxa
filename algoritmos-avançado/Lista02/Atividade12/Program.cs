//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Leia 5 números e mostre a soma deles usando do while
using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira cinco números inteiros. (a b c d e): ");
    var v = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    int soma = 0;
    int i = 0;
    do
    {
      soma += v[i]; 
      i++;
    } while (i < v.Length);
    Console.WriteLine($"Soma: {soma}");
  }
}
