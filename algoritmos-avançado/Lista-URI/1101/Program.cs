using System;
using System.Collections.Generic;
using System.Linq;

class URI {

  static void Main(string[] args) {
    var n = new int[2];
    List<int> Values = new List<int>();
    while (true)
    {
      n = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
      if (n[0] > 0 && n[1] > 1)
      {
        Values.Add(n[0]); 
        Values.Add(n[1]);
      } else break;
    }
    for (int i = 0; i < Values.Count(); i += 2)
    {
      int Soma = 0;
      if (Values[i + 1] < Values[i])
      {
        for (int j = Values[i + 1]; j <= Values[i]; j++)
        {
          Console.Write($"{j} ");
          Soma += j;
        }
      } else for (int j = Values[i]; j <= Values[i + 1]; j++)
      {
        Console.Write($"{j} ");
        Soma += j;
      }
      Console.Write($"Sum={Soma}\n");
    }
  }
}