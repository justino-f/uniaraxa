using System;
using System.Globalization;

class URI {

  static void Main(string[] args) {
    int T = int.Parse(Console.ReadLine());
    string[] Resultados = new string[T];
    for (int i = 0; i < T; i++)
    {
      string[] n = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
      int Contador = 0;
      int PA = int.Parse(n[0]);
      int PB = int.Parse(n[1]);
      double G1 = double.Parse(n[2], CultureInfo.InvariantCulture);
      double G2 = double.Parse(n[3], CultureInfo.InvariantCulture);
      while(PA <= PB && Contador <= 101)
      {
        PA += (int) (PA * (G1 / 100.0));
        PB += (int) (PB * (G2 / 100.0));
        Contador++;
      }
      if (Contador > 100) Resultados[i] = $"Mais de 1 seculo.";
      else Resultados[i] = $"{Contador} anos.";
    } 
    for (int k = 0; k < T; k++) Console.WriteLine($"{Resultados[k]}");
  }
}