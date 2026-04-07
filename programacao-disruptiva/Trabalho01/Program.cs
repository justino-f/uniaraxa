using System;

internal class Program
{
  private const int philosopherCount = 2;
  private static char[] philosopherStates = new[] { 'P', 'P' };
  private static bool[] hasFork = new bool[philosopherCount];
  private static bool[] hasKnife = new bool[philosopherCount];
  private static int philosopher = 1;

  private static void ShowActionMessage(string message)
  {
    Console.WriteLine(message);
    Console.WriteLine("Press any key to continue...");
    Console.ReadKey();
  }

  private static void ShowHeader()
  {
    Console.Clear();
    Console.WriteLine($"Current Philosopher: {philosopher}");
    Console.WriteLine($"Current State: {philosopherStates[philosopher - 1]}");
    Console.WriteLine("============");
    Console.WriteLine();
  }

  private static void ExecuteUntilSuccess(Func<bool> action)
  {
    while (!action()) { }
  }

  private static bool HasOwnForkAndKnife(int philosopherId)
  {
    int index = philosopherId - 1;
    return hasFork[index] && hasKnife[index];
  }

  private static bool IsHoldingAnyCutlery(int philosopherId)
  {
    int index = philosopherId - 1;
    return hasFork[index] || hasKnife[index];
  }

  private static void UpdateStateAfterReturn(int philosopherId)
  {
    int index = philosopherId - 1;
    if (philosopherStates[index] == 'C' && !hasFork[index] && !hasKnife[index])
    {
      philosopherStates[index] = 'P';
      ShowActionMessage($"Philosopher {philosopherId} returned fork and knife, and is back to state P.");
    }
  }

  public static bool Eat()
  {
    if (philosopherStates[philosopher - 1] == 'C')
    {
      ShowActionMessage($"Philosopher {philosopher} is already in state C and cannot eat again right now.");
      return false;
    }

    if (!HasOwnForkAndKnife(philosopher))
    {
      ShowActionMessage($"Philosopher {philosopher} cannot eat: they must hold Fork {philosopher} and Knife {philosopher}.");
      return false;
    }
    philosopherStates[philosopher - 1] = 'C';
    ShowActionMessage($"Philosopher {philosopher} ate successfully and is now in state C.");
    return true;
  }

  public static void DefineInitialState()
  {
    philosopherStates[0] = 'P';
    philosopherStates[1] = 'P';
    hasFork[0] = false;
    hasFork[1] = false;
    hasKnife[0] = false;
    hasKnife[1] = false;
  }

  private static int ReadOptionInRange(int min, int max, string invalidMessage)
  {
    while (true)
    {
      if (int.TryParse(Console.ReadLine(), out int input) && input >= min && input <= max) return input;
      Console.WriteLine(invalidMessage);
    }
  }

  public static int SelectPhilosopher()
  {
    Console.Clear();
    Console.Write($"Select the philosopher (1 to {philosopherCount}): ");
    return ReadOptionInRange(1, philosopherCount, "Invalid philosopher. Try again.");
  }

  public static int ChooseOption()
  {
    ShowHeader();
    Console.WriteLine("[1] - Take Action.");
    Console.WriteLine("[2] - Change Philosopher.");
    Console.WriteLine("[0] - Exit.");
    Console.Write(": ");
    return ReadOptionInRange(0, 2, "Invalid option. Try again.");
  }

  public static bool ChooseFork()
  {
    int itemIndex = philosopher - 1;

    if (hasFork[itemIndex])
    {
      ShowActionMessage($"Philosopher {philosopher} already has Fork {philosopher}.");
      return false;
    }

    hasFork[itemIndex] = true;
    ShowActionMessage($"Philosopher {philosopher} successfully took fork F{philosopher}.");
    return true;
  }

  public static bool ChooseKnife()
  {
    int itemIndex = philosopher - 1;

    if (hasKnife[itemIndex])
    {
      ShowActionMessage($"Philosopher {philosopher} already has Knife {philosopher}.");
      return false;
    }

    hasKnife[itemIndex] = true;
    ShowActionMessage($"Philosopher {philosopher} successfully took knife K{philosopher}.");
    return true;
  }

  public static bool ReturnForkAndKnife()
  {
    int itemIndex = philosopher - 1;

    if (!hasFork[itemIndex] || !hasKnife[itemIndex])
    {
      ShowActionMessage($"Philosopher {philosopher} can only return cutlery when holding both Fork {philosopher} and Knife {philosopher}.");
      return true;
    }

    hasFork[itemIndex] = false;
    hasKnife[itemIndex] = false;
    UpdateStateAfterReturn(philosopher);
    return true;
  }

  public static void ChooseAction()
  {
    while (true)
    {
      ShowHeader();
      Console.WriteLine("[1] - Take Fork");
      Console.WriteLine("[2] - Take Knife");
      Console.WriteLine("[3] - Return Fork and Knife");
      Console.WriteLine("[4] - Eat");
      Console.WriteLine("[0] - Back");
      Console.Write(": ");

      int input = ReadOptionInRange(0, 4, "Invalid option. Try again.");
      switch (input)
      {
        case 1:
          ExecuteUntilSuccess(() => ChooseFork());
          break;
        case 2:
          ExecuteUntilSuccess(() => ChooseKnife());
          break;
        case 3:
          ExecuteUntilSuccess(() => ReturnForkAndKnife());
          break;
        case 4:
          Eat();
          break;
        case 0:
          return;
      }
    }
  }

  public static void ChoosePhilosopher()
  {
    if (IsHoldingAnyCutlery(philosopher))
    {
      ShowActionMessage($"Philosopher {philosopher} cannot be changed until all held cutlery is returned.");
      return;
    }

    philosopher = SelectPhilosopher();
  }

  static void Main(string[] args)
  {
    DefineInitialState();
    philosopher = SelectPhilosopher();

    while (true)
    {
      switch (ChooseOption())
      {
        case 1:
          ChooseAction();
          break;
        case 2:
          ChoosePhilosopher();
          break;
        case 0:
          Console.Clear();
          return;
      }
    }
  }
}