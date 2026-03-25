using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira 15 números inteiros. (a b c d etc.): ");
    var n = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int i = 0; i < n.Length; i++) if (i % 2 == 0) Console.WriteLine($"{n[i]}");
  }
}