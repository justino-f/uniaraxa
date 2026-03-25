using System;

internal class Program
{
  static void Main(string[] args)
  {
    Console.Write("Insira o nome e o preço de 10 produtos. (nome preco nome preco etc.): ");
    var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
    string[] nomes = new string[input.Length / 2];
    double[] precos = new double[input.Length / 2];
    int j = 0;
    for (int i = 0; i < 20; i += 2)
    {
      nomes[j] = input[i];
      precos[j] = double.Parse(input[i + 1]);
      Console.Write($"{nomes[j]} {precos[j]} ");
      j++;
    }
  }
}