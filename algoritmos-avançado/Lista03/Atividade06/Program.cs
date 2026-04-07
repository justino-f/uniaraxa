using System;

internal class Program
{
  static void RenderizarTabuleiro(string[,] tabuleiro, string vezAtual, int inputX, int inputY)
  {
    Console.Clear();
    Console.WriteLine($"Vez de: {vezAtual}");
    Console.WriteLine("Use as setas para mover e Enter para confirmar.");
    Console.WriteLine();

    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        if (i == inputX && j == inputY)
          Console.Write($"[{tabuleiro[i, j]}]");
        else
          Console.Write($" {tabuleiro[i, j]} ");
      }
      Console.WriteLine();
    }
  }

  static (int x, int y) LerPosicaoComSetas(string[,] tabuleiro, string vezAtual)
  {
    int inputX = 0;
    int inputY = 0; 

    while (true)
    {
      RenderizarTabuleiro(tabuleiro, vezAtual, inputX, inputY);

      ConsoleKeyInfo tecla = Console.ReadKey(true);

      if (tecla.Key == ConsoleKey.UpArrow && inputX > 0) inputX--;
      else if (tecla.Key == ConsoleKey.DownArrow && inputX < 2) inputX++;
      else if (tecla.Key == ConsoleKey.LeftArrow && inputY > 0) inputY--;
      else if (tecla.Key == ConsoleKey.RightArrow && inputY < 2) inputY++;
      else if (tecla.Key == ConsoleKey.Enter) return (inputX, inputY);
    }
  }

  static string? ChecarVitoria(string[,] tabuleiro)
  {
    for (int i = 0; i < 3; i++)
    {
      string s = tabuleiro[i, 0];
      if (s != "*" && s == tabuleiro[i, 1] && s == tabuleiro[i, 2]) return s;
    }

    for (int j = 0; j < 3; j++)
    {
      string s = tabuleiro[0, j];
      if (s != "*" && s == tabuleiro[1, j] && s == tabuleiro[2, j]) return s;
    }

    string d1 = tabuleiro[0, 0];
    if (d1 != "*" && d1 == tabuleiro[1, 1] && d1 == tabuleiro[2, 2]) return d1;

    string d2 = tabuleiro[0, 2];
    if (d2 != "*" && d2 == tabuleiro[1, 1] && d2 == tabuleiro[2, 0]) return d2;

    return null;
  }

  static bool ChecarEmpate(string[,] tabuleiro)
  {
    for (int i = 0; i < 3; i++)
    {
      for (int j = 0; j < 3; j++)
      {
        if (tabuleiro[i, j] == "*") return false;
      }
    }

    return true;
  }

  static void Main(string[] args)
  {
    string[,] tabuleiro = new string[3, 3];
    string[] jogadores = ["X", "O"];
    int rodadas = 1;

    for (int i = 0; i < 3; i++)
      for (int j = 0; j < 3; j++)
        tabuleiro[i, j] = "*";

    string? resultado = null;
    while (resultado == null)
    {
      if (rodadas % 2 == 0)
      {
        var posicao = LerPosicaoComSetas(tabuleiro, jogadores[1]);
        if (tabuleiro[posicao.x, posicao.y] == "*")
        {
          tabuleiro[posicao.x, posicao.y] = "O";
          rodadas++;
        }
      }
      else
      {
        var posicao = LerPosicaoComSetas(tabuleiro, jogadores[0]);
        if (tabuleiro[posicao.x, posicao.y] == "*")
        {
          tabuleiro[posicao.x, posicao.y] = "X";
          rodadas++;
        }
      }
      resultado = ChecarVitoria(tabuleiro);

      if (resultado == null && ChecarEmpate(tabuleiro))
      {
        Console.Clear();
        RenderizarTabuleiro(tabuleiro, "-", -1, -1);
        Console.WriteLine("Empate!");
        return;
      }
    }
    Console.Clear();
    RenderizarTabuleiro(tabuleiro, "-", -1, -1);
    Console.WriteLine($"O vencedor é: {resultado}");
  }
}