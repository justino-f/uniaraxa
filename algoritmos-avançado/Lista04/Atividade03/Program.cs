using System;

internal class Program
{
  static void Main(string[] args)
  {
    int[] Vetor = new int[8];
    for (int i = 0; i < 8; i++) Vetor[i] = int.Parse(Console.ReadLine());
    int Input = int.Parse(Console.ReadLine());
    int j = 0;
    bool Achou = false;
    for (j = 0; j < Vetor.Length; j++)
    {
      if (Input == Vetor[j])
      {
        Achou = true;
        break;
      }
    }
    if (!Achou) Console.WriteLine("O número não se encontra no vetor");
    else Console.WriteLine(j);
  }
}