using System; 

class URI {

  static void Main(string[] args) { 

    int X = int.Parse(Console.ReadLine());
    string[] Resultados = new string[X];
    for (int i = 0; i < X; i++)
    {
      int N = int.Parse(Console.ReadLine()); 
      int Contador = 0;
      for (int j = 1; j <= N; j++)
      {
        if (N % j == 0) Contador++;
      }
      if (Contador == 2) Resultados[i] = $"{N} eh primo";
      else Resultados[i] = $"{N} nao eh primo";
    }
    for (int k = 0; k < X; k++) Console.WriteLine($"{Resultados[k]}");
  }
}