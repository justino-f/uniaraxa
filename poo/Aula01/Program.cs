internal class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("Hello VSCode");
    Console.WriteLine($"Date: {DateTime.Now}");
    Console.Write("Type your name: ");

    string name = Console.ReadLine();
    
    Console.WriteLine($"Welcome {name}!");
    
    Console.ReadKey();
  }
}