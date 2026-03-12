using System;
using System.Linq;

class URI {
  static void Main(string[] args) { 
    var N = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

    int Linha = 1;
    for (int i = 1; i <= N[1]; i += N[0])
    {
      
      for (int j = i; j <= N[0] * Linha; j++)
      {
        if (j == N[0] * Linha) Console.Write($"{j}\n");
        else Console.Write($"{j} ");
      }
      Linha++;
    }
  }
}