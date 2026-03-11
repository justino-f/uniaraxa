using System;
using System.Globalization;

class URI
{
  static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());
    int C = 0;
    int R = 0;
    int S = 0;

    for (int i = 0; i < N; i++)
    {
      string[] v = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
      int quantidade = int.Parse(v[0]);

      switch (v[1])
      {
        case "C":
          C += quantidade;
          break;
        case "R":
          R += quantidade;
          break;
        case "S":
          S += quantidade;
          break;
      }
    }

    int total = C + R + S;
    Console.WriteLine("Total: " + total + " cobaias");
    Console.WriteLine("Total de coelhos: " + C);
    Console.WriteLine("Total de ratos: " + R);
    Console.WriteLine("Total de sapos: " + S);
    Console.WriteLine("Percentual de coelhos: " + ((C * 100.0) / total).ToString("F2", CultureInfo.InvariantCulture) + " %");
    Console.WriteLine("Percentual de ratos: " + ((R * 100.0) / total).ToString("F2", CultureInfo.InvariantCulture) + " %");
    Console.WriteLine("Percentual de sapos: " + ((S * 100.0) / total).ToString("F2", CultureInfo.InvariantCulture) + " %");
  }
}