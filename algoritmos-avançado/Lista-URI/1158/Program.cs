using System; 
using System.Linq;

class URI {

  static void Main(string[] args) { 

    int N = int.Parse(Console.ReadLine());
    int[] Somas = new int[N];
    for (int i = 0; i < N; i++)
    {
      int[] n = Console.ReadLine()
        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

      int Index = n[0];
      if (Index % 2 != 0) for (int j = 1; j <= n[1]; j++)
      {
        Somas[i] += Index;
        Index += 2;
      }
      else
      {
        Index++;
        for (int j = 1; j <= n[1]; j++)
        {
        Somas[i] += Index;
        Index += 2;
        }
      } 
    }
    for (int k = 0; k < N; k++) Console.WriteLine($"{Somas[k]}");
  }
}