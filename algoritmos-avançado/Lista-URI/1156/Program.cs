using System; 

class URI {

  static void Main(string[] args) { 
    double S = 0.0;
    double Denominador = 1.0;
    for (double i = 1; i <= 39; i += 2)
    {
      S += i/Denominador;
      Denominador *= 2;
    }

    Console.WriteLine($"{S:F2}");
  }
}