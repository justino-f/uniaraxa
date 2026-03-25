using System;

internal class Program
{
  static void Main(string[] args)
  {
    double[] Salarios = new double[10];
    string Output = "";
    for (int i = 0; i < 10; i++)
    {
     Salarios[i] = double.Parse(Console.ReadLine());
     Salarios[i] = Salarios[i] + (Salarios[i] * 0.05); 
     Output += $"{Salarios[i]} ";
    }
    Console.WriteLine(Output);
  }
}