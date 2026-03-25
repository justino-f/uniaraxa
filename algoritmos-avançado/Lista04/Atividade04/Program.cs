using System;

internal class Program
{
  static void Main(string[] args)
  {
    int[] Vetor1 = new int[10];
    int[] Vetor2 = new int[10];
    int[] VetorSoma = new int[10];
    string Output = "";
    for (int i = 0; i < 10; i++)
    {
      Console.Write($"Insira Vetor1[{i}]: ");
      Vetor1[i] = int.Parse(Console.ReadLine());
      Console.Write($"Insira Vetor2[{i}]: ");
      Vetor2[i] = int.Parse(Console.ReadLine());
      VetorSoma[i] = Vetor1[i] + Vetor2[i];
      Output += $"{VetorSoma[i]} ";
    }
    Console.WriteLine(Output);
  }
}