//Disciplina: Algoritmos e Programação Avançada
//Professor: Estheban Rivas
//Aluno: Renato Justino
//Leia três números e mostre a soma apenas se todos forem positivos. Senão, mostre erro.
using System;

internal class Program
{
  static void Main(string[] args)
  {
    try
    {
      Console.Write("Insira três valores positivos. (X Y Z): ");
      var v = Console.ReadLine()!.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
      if(v.Length != 3 || v.Any(n => n < 0)) throw new Exception();
      else Console.WriteLine($"Soma: {v[0] + v[1] + v[2]}");
    }
    catch {
      Console.WriteLine("Insira valores válidos!");
    }
  }
}
