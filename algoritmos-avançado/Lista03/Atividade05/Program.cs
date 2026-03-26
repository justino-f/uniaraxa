using System;

internal class Program
{
  static void Main(string[] args)
  {
    Dictionary<string, double[]> AlunosNotas = new Dictionary<string, double[]>();
    double[] Medias = new double[10];
    string[] Status = new string[10];
    for (int i = 0; i < 10; i++)
    {
      var linha = Console.ReadLine();
      var n = linha.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
      AlunosNotas[n[0]] = [double.Parse(n[1]), double.Parse(n[2]), double.Parse(n[3])];
      Medias[i] = (AlunosNotas[n[0]][0] + AlunosNotas[n[0]][1] + AlunosNotas[n[0]][2]) / 3.0;
      if (Medias[i] >= 7.0 ) Status[i] = "Aprovado";
      else Status[i] = "Reprovado";
    }
    int j = 0;
    foreach (var nome in AlunosNotas.Keys){
      Console.WriteLine($"{nome} | {AlunosNotas[nome][0]}, {AlunosNotas[nome][1]}, {AlunosNotas[nome][2]} | {Medias[j]:F2} | {Status[j]}");
      j++;
    }
  }
}