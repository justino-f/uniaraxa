using System;
using System.Linq;

class URI {

  static void Main(string[] args) { 

    var n = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    int Soma = 0;
    int N = 0;
    for (int i = 1; i < n.Length; i++)
    {
      if (n[i] > 0) N = n[i];
    }
    for (int i = 0; i < N; i++)
    {
      Soma += n[0] + i;
    }
    Console.WriteLine(Soma);
  }

}