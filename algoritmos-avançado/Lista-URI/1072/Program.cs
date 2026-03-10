using System; 
class URI {

  static void Main(string[] args) { 
    int N = int.Parse(Console.ReadLine()!);
    int In = 0, Out = 0;
    for (int i = 0; i < N; i++){
      int X = int.Parse(Console.ReadLine()!);
      if (X < 10 || X > 20) Out++;
      else In++;
    }
    Console.WriteLine($"{In} in");
    Console.WriteLine($"{Out} out\n");
  }
}