namespace SectraCalculator;

public static class Messages
{
  public static void AppStart()
  {
    Console.WriteLine();
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("||**|| Welcome to the transaction calculator ||**||");
    Console.ResetColor();
    Console.WriteLine();
  }
  public static void Prompt()
  {
    Console.WriteLine();
    Console.Write("Enter your chosen register name followed by operation and value like this: ");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("A Add 5 ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("then hit ");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Enter");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(" to add a new transaction.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Type ");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Print");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" followed by the Register you wish to print, ex:");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(" 'Print A'");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Type ");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("'Quit'");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" to exit.");
    Console.ResetColor();
    Console.WriteLine();
    Console.WriteLine();
  }
  public static void InputNumeric()
  {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Input numeric value");
    Console.ResetColor();
    Console.WriteLine();
  }
  public static void InputOperator()
  {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("input operationtype; Add, Subtract or Multiply");
    Console.ResetColor();
    Console.WriteLine();
  }
  public static void InputRegister()
  {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Input register");
    Console.ResetColor();
    Console.WriteLine();
  }
  public static void OperatorErrorMessage()
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Unsupported operation type.");
    Console.WriteLine("Restarting transaction input.");
    Thread.Sleep(500);
    Console.ResetColor();
    Console.WriteLine();
  }
  public static void CurrentValue(string register, double result)
  {
    Console.WriteLine();
    Console.Write("Current value of ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{register}");
    Console.ResetColor();
    Console.Write(" is: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{result}");
    Console.ResetColor();
    Thread.Sleep(1000);
    Console.WriteLine();
  }
  public static void PressSomething()
  {
    Console.Write("You need to add something other than just hitting ");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Enter");
    Console.ForegroundColor = ConsoleColor.White;
  }
}