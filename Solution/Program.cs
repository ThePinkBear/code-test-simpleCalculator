using SectraCalculator;

internal class Program
{
  public static void Main(string[] args)
  {
    Messages.AppStart();
    FileInput fileReader = new();
    UserInput userReader = new();
    if (args.Length == 1)
    {
      using (var file = new StreamReader(args[0]))
      {
        fileReader.FileInputLogic(file);
      }
    }
    else
    {
      userReader.UserInputLogic();
    }
  }
}