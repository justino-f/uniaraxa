internal class Program
{
  static void Main(string[] args)
  {
    int A;
    int B;
    int C;
    int X;

    A = int.Parse(Console.ReadLine());
    B = int.Parse(Console.ReadLine());
    C = int.Parse(Console.ReadLine());

    X = A * (B + C);

    Console.WriteLine($"X: {X}");
  }
}