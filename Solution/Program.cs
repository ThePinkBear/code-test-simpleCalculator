using TransactionCalculator;

internal class Program
{
  public static void Main(string[] args)
  {
    Messages.AppStart();
    FileInput fileInput = new();
    UserInput userInput = new();
    
    if (args.Length == 1)
    {
      using (var file = new StreamReader(args[0]))
      {
        fileInput.FileInputLogic(file);
      }
    }
    else
    {
      userInput.UserInputLogic();
    }
  }
}
