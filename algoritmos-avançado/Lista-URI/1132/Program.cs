using System; 

class URI {
  static void Main(string[] args) { 
    int X = int.Parse(Console.ReadLine());
    int Y = int.Parse(Console.ReadLine());
    int Soma = 0;
    if (X > Y) for (int i = Y; i <= X; i++)
    {
      if (i % 13 != 0) Soma += i;
    }
    else for (int i = X; i <= Y; i++)
    {
      if (i % 13 != 0) Soma += i;
    } 
    Console.WriteLine($"{Soma}");
  }
}