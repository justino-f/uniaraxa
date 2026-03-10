using System; 
class URI {

  static void Main(string[] args) { 
    int N = int.Parse(Console.ReadLine());
    string[][] Output = new string[N][];
    for (int i = 0; i < N; i++)
    {
      int X = int.Parse(Console.ReadLine());
      Output[i] = new string[2];
      if (X % 2 == 0) Output[i][0] = "EVEN ";
      else Output[i][0] = "ODD ";
      if (X > 0) Output[i][1] = "POSITIVE";
      else if (X < 0)Output[i][1] = "NEGATIVE";
      else
      {
        Output[i][0] = "NULL";
        Output[i][1] = null;
      } 
    }
    for (int j = 0; j < N; j++) Console.WriteLine($"{Output[j][0]}{Output[j][1]}");
  }
}