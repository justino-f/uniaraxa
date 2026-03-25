using System;

internal class Program
{
  static void Main(string[] args)
  {
    int[] Vetor = new int[15];
    for (int i = 0; i < 15; i++)
    {
      Vetor[i] = int.Parse(Console.ReadLine());
    }
    foreach (int n in Vetor)
    {
      if (n > 0) Console.Write($"{n} ");
    }
  }
}