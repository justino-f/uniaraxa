using System;

internal class Program
{
  static void Main(string[] args)
  {
    int[,] Matriz = new int[5, 5];
    int Index = 1;
    string Output = "";
    for (int i = 0; i < 5; i++)
    {
      for (int j = 0; j < 5; j++)
      {
        Matriz[i, j] = Index;
        Index++;
      }
      Output += $"{Matriz[i, i]} ";
    }
    Console.WriteLine(Output);
  }
}