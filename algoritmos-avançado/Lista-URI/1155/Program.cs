using System; 

class URI {

  static void Main(string[] args) {
    double S = 0;
    for (double i = 1.0; i <= 100.0; i++)
    {
      S += 1/i;
    }
    Console.WriteLine($"{S:F2}");
  }
}