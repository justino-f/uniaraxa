using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira as dimensões X e Y da matriz. (X Y): ");
    Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    
  }
}