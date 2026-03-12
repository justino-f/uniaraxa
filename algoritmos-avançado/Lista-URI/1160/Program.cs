using System; 

class URI {

  static void Main(string[] args) {
    int T = int.Parse(Console.ReadLine());
    string[] Resultados = new string[T];
    for (int i = 0; i < T; i++)
    {
      var n = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
      int Contador = 0;
      double PA = n[0];
      double PB = n[1];
      double G1 = n[2];
      double G2 = n[3];
      while((int) PA <= (int) PB)
      {
        PA += PA * (G1 / 100);
        PB += PB * (G2 / 100);
        Contador++;
        Console.WriteLine(PA);
        Console.WriteLine(PB);
      }
      Resultados[i] = $"{Contador} anos.";
    } 
    for (int k = 0; k < T; k++) Console.WriteLine($"{Resultados[k]}");
  }
}