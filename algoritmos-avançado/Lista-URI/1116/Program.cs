using System;
using System.Globalization;

class URI {

  static void Main(string[] args) { 
    int N = int.Parse(Console.ReadLine());
    string[] Resultados = new string[N];
    for (int i = 0; i < N; i++)
    {
      string[] entrada = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
      double x = double.Parse(entrada[0], CultureInfo.InvariantCulture);
      double y = double.Parse(entrada[1], CultureInfo.InvariantCulture);
      if (y != 0) Resultados[i] = (x / y).ToString("F1", CultureInfo.InvariantCulture);
      else Resultados[i] = "divisao impossivel";
    }
    for (int j = 0 ; j < N; j++) Console.WriteLine(Resultados[j]);
  }
}