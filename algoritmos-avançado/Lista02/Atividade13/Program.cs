//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Leia 2 números e um operador e mostre o resultado.
using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira dois números inteiros. (X Y): ");
    var v = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    Console.Write("Insira um operador. (* / + -): ");
    string input = Console.ReadLine()!;
    double resultado = 0;
    switch (input)
    {
      case "*":
        resultado = v[0] * v[1];
        break;
      case "/":
        resultado = (double) v[0] / v[1];
        break;
      case "+":
        resultado = v[0] + v[1];
        break;
      case "-":
        resultado = v[0] - v[1];
        break;
    }
    Console.WriteLine($"Resultado: {resultado}");
  }
}
