using System;
using System.Linq;

class URI {

  static void Main(string[] args) { 
    int N = int.Parse(Console.ReadLine());
    int[] Values = new int[N];
    for (int i = 0; i < N; i++)
    {
      var n = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
      int Soma = 0;
      if (n[0] > n[1])
      {
        for (int j = n[0] - 1; j > n[1]; j--)
        {
          if (j % 2 != 0) Soma += j;
        }
      }
      else
      {
        for (int j = n[1] - 1; j > n[0]; j--)
        {
          if (j % 2 != 0) Soma += j;
        }
      }
      Values[i] = Soma;
    }
    for (int k = 0; k < N; k++) Console.WriteLine($"{Values[k]}");
  }
}