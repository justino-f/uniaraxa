using System; 

class URI {
  static void Main(string[] args) { 

    int N = int.Parse(Console.ReadLine());
    int DigitoA = 0;
    int DigitoB = 0;
    int DigitoAtual;
    int[] Numeros = new int[N];
    for (int i = 0; i < N; i++)
    {
      if (i == 0 || i == 1)
      {
        DigitoAtual = i;
        Numeros[i] = DigitoAtual;
        DigitoA = DigitoB;
        DigitoB = DigitoAtual;
        continue;
      }
      DigitoAtual = DigitoA + DigitoB;
      Numeros[i] = DigitoAtual;
      DigitoA = DigitoB;
      DigitoB = DigitoAtual;
    }
    for (int j = 0; j < N; j++)
    {
      if (j == N - 1) Console.WriteLine($"{Numeros[j]}");
      else Console.Write($"{Numeros[j]} ");
    }
  }
}