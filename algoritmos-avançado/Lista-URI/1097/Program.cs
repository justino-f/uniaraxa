using System; 

class URI {

  static void Main(string[] args) { 
    int k = 5;
    for (int i = 1; i <= 9; i += 2)
    {
      for (int j = k + 2; j >= k; j--)
      {
        Console.WriteLine($"I={i} J={j}");
      }

      k += 2;
    }
  }
}