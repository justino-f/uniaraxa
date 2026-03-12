using System; 

class URI {

  static void Main(string[] args) {
    int X = int.Parse(Console.ReadLine());
    int Z;
    do
    {
      Z = int.Parse(Console.ReadLine());
    } while (Z <= X);
    int Index = 1;
    int Soma = 0;
    while (Soma <= Z)
    {
      Index++;
      Soma += X + Index;
    }
    Console.WriteLine(Index);
  }
}