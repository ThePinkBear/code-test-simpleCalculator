namespace TransactionCalculator;

public static class Messages
{
  public static void AppStart()
  {
    Console.WriteLine();
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("\t---------------------------------------------------");
    Console.Write("\t||**||");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" Welcome to the Transaction Calculator ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("||**||");
    Console.WriteLine("\t---------------------------------------------------");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
    Console.Write("Rerun program with a file path added if you wish to read your transactions from a file: \nExample: \n");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("'dotnet run C:\\Users\\User\\Desktop\\test.txt' \n");
    Console.ForegroundColor = ConsoleColor.White;
  }
  public static void AppEnd()
  {
    Console.WriteLine();
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("||**|| Thank you for trying the Transaction Calculator ||**||");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
  }
  public static void Prompt()
  {
    Console.WriteLine();
    Console.Write("Enter your chosen register name followed by operation and value like this: \n");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("A Add 5\n");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("then hit '");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Enter");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("' to add a new transaction.");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Type ");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("'Quit'");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" to exit.");
    Console.WriteLine();
    Console.WriteLine();
  }
  public static void ContinousPrompt()
  {
    Console.WriteLine();
    Console.Write("Keep adding transactions ex: ");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.Write("A Add 5 ");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("then hit ");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Enter");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine(". \nOr:");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Type '");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Print");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("' followed by the Register you wish to print, ex:");
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(" 'Print A'");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("Type ");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("'Quit'");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" to exit.");
    Console.WriteLine();
    Console.WriteLine();
  }
  public static void InputNumeric()
  {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Input numeric value");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
  }
  public static void InputOperator()
  {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("input operationtype; Add, Subtract or Multiply");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
  }
  public static void InputRegister()
  {
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Input register");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
  }
  public static void OperatorErrorMessage(string errorMessage)
  {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(errorMessage);
    Console.ForegroundColor = ConsoleColor.White;
    Thread.Sleep(1000);
    Console.WriteLine();
  }
  public static void CurrentValue(string register, double result)
  {
    Console.WriteLine();
    Console.Write("Current value of ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{register}");
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" is: ");
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($"{result}");
    Console.ForegroundColor = ConsoleColor.White;
    Thread.Sleep(1000);
    Console.WriteLine();
  }
  public static void PressSomething()
  {
    Console.Write("You need to add something other than just hitting ");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Write("Enter");
    Console.ForegroundColor = ConsoleColor.White;
    Thread.Sleep(1000);
    Console.WriteLine();
  }
}