using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira as dimensões X e Y da matriz. (X Y): ");
    var n = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    int[,] Matriz = new int[n[0], n[1]];
    int[] Soma = new int[n[0]];
    string OutputMatriz = "";
    string OutputSoma = "";
    for (int i = 0; i < n[0]; i++)
    {
      for (int j = 0; j < n[1]; j++)
      {
        Matriz[i, j] = int.Parse(Console.ReadLine());
        Soma[i] += Matriz[i, j];
        OutputMatriz += $"{Matriz[i, j]} ";
      }
      OutputMatriz += "\n";
      OutputSoma += $"{Soma[i]} ";
    }
    Console.WriteLine($"{OutputMatriz} {OutputSoma}");
  }
}