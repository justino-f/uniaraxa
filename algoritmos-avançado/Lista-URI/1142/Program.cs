using System; 

class URI {
  static void Main(string[] args) { 
    int N = int.Parse(Console.ReadLine());
    for (int i = 0; i < N * 4; i += 4) Console.WriteLine($"{i + 1} {i + 2} {i + 3} PUM"); 
  }
}