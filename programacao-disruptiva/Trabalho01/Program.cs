using System;

internal class Program
{
  private static int philosopherCount;
  private static char[] philosopherStates = Array.Empty<char>();
  private static string[] tableObjects = Array.Empty<string>();
  private static int[] forkOwner = Array.Empty<int>();
  private static int[] knifeOwner = Array.Empty<int>();
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
    return forkOwner[index] == philosopherId && knifeOwner[index] == philosopherId;
  }

  private static void UpdateStateAfterReturn(int philosopherId)
  {
    int index = philosopherId - 1;
    if (philosopherStates[index] == 'C' && forkOwner[index] == 0 && knifeOwner[index] == 0)
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
    for (int i = 0; i < philosopherCount; i++)
    {
      philosopherStates[i] = 'P';
    }
  }

  public static void DefineTableObjects()
  {
    for (int i = 0; i < philosopherCount; i++)
    {
      tableObjects[i * 2] = $"F{i + 1}";
      tableObjects[(i * 2) + 1] = $"K{i + 1}";
    }
  }

  public static void ShowTableObjects()
  {
    Console.Clear();
    for (int i = 0; i < philosopherCount; i++)
    {
      Console.WriteLine($"Philosopher {i + 1}: {tableObjects[i * 2]} and {tableObjects[(i * 2) + 1]}");
    }

    Console.Write("Press any key to continue...");
    Console.ReadKey();
  }

  private static int ReadOptionInRange(int min, int max, string invalidMessage)
  {
    while (true)
    {
      string? input = Console.ReadLine();
      if (int.TryParse(input, out int value) && value >= min && value <= max)
      {
        return value;
      }

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

  private static bool ChooseItem(bool isFork, bool returnToTable)
  {
    ShowHeader();

    string itemName = isFork ? "Fork" : "Knife";
    string itemNameLower = isFork ? "fork" : "knife";
    char itemPrefix = isFork ? 'F' : 'K';
    int[] owner = isFork ? forkOwner : knifeOwner;

    for (int i = 0; i < philosopherCount; i++)
    {
      Console.WriteLine($"[{i + 1}] - {itemName} {i + 1}");
    }

    Console.WriteLine("[0] - Back");
    Console.Write(": ");

    int input = ReadOptionInRange(0, philosopherCount, "Invalid option. Try again.");
    if (input == 0)
    {
      return true;
    }

    int itemIndex = input - 1;
    int tableIndex = (itemIndex * 2) + (isFork ? 0 : 1);

    if (!returnToTable)
    {
      if (tableObjects[tableIndex] == " ")
      {
        ShowActionMessage($"Philosopher {philosopher} couldn't take {itemNameLower} {input}: {itemName} {input} is already in use.");
        return false;
      }

      string item = tableObjects[tableIndex];
      tableObjects[tableIndex] = " ";
      owner[itemIndex] = philosopher;
      ShowActionMessage($"Philosopher {philosopher} successfully took {itemNameLower} {item}.");
      return true;
    }

    if (owner[itemIndex] != philosopher)
    {
      if (owner[itemIndex] == 0)
      {
        ShowActionMessage($"Philosopher {philosopher} couldn't return {itemNameLower} {input}: {itemNameLower} {input} is already on the table.");
      }
      else
      {
        ShowActionMessage($"Philosopher {philosopher} couldn't return {itemNameLower} {input}: only philosopher {owner[itemIndex]} can return it.");
      }

      return false;
    }

    tableObjects[tableIndex] = $"{itemPrefix}{input}";
    owner[itemIndex] = 0;
    ShowActionMessage($"Philosopher {philosopher} returned {itemNameLower} {itemPrefix}{input} to the table.");
    UpdateStateAfterReturn(philosopher);
    return true;
  }

  public static bool ChooseFork(bool returnToTable = false)
  {
    return ChooseItem(isFork: true, returnToTable: returnToTable);
  }

  public static bool ChooseKnife(bool returnToTable = false)
  {
    return ChooseItem(isFork: false, returnToTable: returnToTable);
  }

  public static void ChooseAction()
  {
    while (true)
    {
      ShowHeader();
      Console.WriteLine("[1] - Take Fork");
      Console.WriteLine("[2] - Take Knife");
      Console.WriteLine("[3] - Return Fork");
      Console.WriteLine("[4] - Return Knife");
      Console.WriteLine("[5] - Eat");
      Console.WriteLine("[0] - Back");
      Console.Write(": ");

      int input = ReadOptionInRange(0, 5, "Invalid option. Try again.");
      switch (input)
      {
        case 1:
          ExecuteUntilSuccess(ChooseFork);
          break;
        case 2:
          ExecuteUntilSuccess(ChooseKnife);
          break;
        case 3:
          ExecuteUntilSuccess(() => ChooseFork(true));
          break;
        case 4:
          ExecuteUntilSuccess(() => ChooseKnife(true));
          break;
        case 5:
          Eat();
          break;
        case 0:
          return;
      }
    }
  }

  public static void ChoosePhilosopher()
  {
    philosopher = SelectPhilosopher();
  }

  static void Main(string[] args)
  {
    Console.Clear();
    Console.Write("Please define how many philosophers there are: ");
    philosopherCount = ReadOptionInRange(1, int.MaxValue, "Invalid number. Try again.");

    philosopherStates = new char[philosopherCount];
    tableObjects = new string[2 * philosopherCount];
    forkOwner = new int[philosopherCount];
    knifeOwner = new int[philosopherCount];

    DefineInitialState();
    DefineTableObjects();
    ShowTableObjects();
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