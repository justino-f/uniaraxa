using System;

internal class Program
{
  static void Main(string[] args)
  {
    int[] Vetor = new int[10];
    int Soma = 0;
    for (int i = 0; i < 10; i++)
    {
      Vetor[i] = int.Parse(Console.ReadLine());
      Soma += Vetor[i];
    }
    Console.WriteLine(Soma);
  }
}