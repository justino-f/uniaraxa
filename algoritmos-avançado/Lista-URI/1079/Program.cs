using System;
using System.Globalization;

class URI
{
  static void Main(string[] args)
  {
    int N = int.Parse(Console.ReadLine());
    double[] Medias = new double[N];

    for (int i = 0; i < N; i++)
    {
      string[] n = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
      double a = double.Parse(n[0], CultureInfo.InvariantCulture);
      double b = double.Parse(n[1], CultureInfo.InvariantCulture);
      double c = double.Parse(n[2], CultureInfo.InvariantCulture);
      Medias[i] = ((a * 2) + (b * 3) + (c * 5)) / 10.0;
    }

    for (int j = 0; j < N; j++)
    {
      Console.WriteLine(Medias[j].ToString("F1", CultureInfo.InvariantCulture));
    }
  }
}