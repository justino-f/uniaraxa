using System; 

class URI {

  static void Main(string[] args) { 
    
    int Maior = 0;
    int Index = 0;

    for (int i = 0; i < 100; i++)
    {
      int X = int.Parse(Console.ReadLine());

      if (i == 0)
      {
        Maior = X;
        Index = i + 1;
      }
      else if (X > Maior)
      {
        Maior = X;
        Index = i + 1;
      }
    }
    Console.WriteLine(Maior);
    Console.WriteLine(Index);
  }
}