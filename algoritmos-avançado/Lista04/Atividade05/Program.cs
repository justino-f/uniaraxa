using System;

internal class Program
{
  static void Main(string[] args)
  {
    int[] Vetor = new int[20];
    int Pares = 0;
    int Impares = 0;
    int Maior50 = 0;
    int Menor7 = 0;
    for (int i = 0; i < 20; i++)
    {
      Vetor[i] = int.Parse(Console.ReadLine());
      if (Vetor[i] % 2 == 0) Pares++;
      else Impares++;
      if (Vetor[i] > 50) Maior50++;
      else if (Vetor[i] < 7) Menor7++;
    }
    Console.WriteLine($"{Pares} {Impares} {Maior50} {Menor7}");
  }
}