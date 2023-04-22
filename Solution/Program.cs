using SectraCalculator;

internal class Program
{
  public static void Main(string[] args)
  {
    Messages.AppStart();

    var calculator = new TransactionReader();
    var user = new UserInput();
    if (args.Length == 1)
    {
        using (var file = new StreamReader(args[0]))
        {
            calculator.Extract(file);
        }
    }
    else
    {
        user.UserInputLogic();
    }
  }
}