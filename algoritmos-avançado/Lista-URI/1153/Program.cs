using System; 

class URI {

  static void Main(string[] args) {
    
    int N = int.Parse(Console.ReadLine());
    for (int i = N - 1; i > 1; i--)
    {
      N *= i;
    }
    Console.WriteLine($"{N}");
  }
}