using System;

internal class Program
{
  static void Main(string[] args)
  {
    double[] Vetor = new double[10];
    string Output = "";
    double Buffer = 0;
    for (int i = 0; i < 10; i++)
    {
      Vetor[i] = double.Parse(Console.ReadLine());
      Output += $"{Vetor[i]} ";
    }
    Console.WriteLine($"Vetor Atual: {Output}");
    for (int j = 0; j < (Vetor.Length / 2); j++)
    {
      Buffer = Vetor[j];
      Vetor[j] = Vetor[Vetor.Length - (j + 1)];
      Vetor[Vetor.Length - (j + 1)] = Buffer;
    }
    Console.Write("Vetor Invertido: ");
    for (int k = 0; k < Vetor.Length; k++) Console.Write($"{Vetor[k]} ");
  }
}