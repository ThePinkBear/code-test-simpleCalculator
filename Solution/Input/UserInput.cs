namespace TransactionCalculator;

public class UserInput
{

  public void UserInputLogic()
  {
    Dictionary<string, double> registerValue = new();
    List<Transaction> transactions = new();
    Messages.Prompt();
    TransactionCrafter tr = new();
    string[]? cmd;
    var message = "Available operations are: Add, Subtract & Multiply \nRetry please.";
    while ((cmd = Console.ReadLine()?.ToLower().Split(" ")) != null)
    {
      if (cmd[0] == "")
      {
        Messages.PressSomething();
        Thread.Sleep(1000);
        Messages.ContinousPrompt();
        continue;
      }

      if (cmd[0] == "quit")
      {
        Messages.AppEnd();
        Thread.Sleep(1000);
        Environment.Exit(0);
      }
      if (cmd[0] == "print")
      {
        Calculator calc = new(registerValue, transactions);
        calc.Caluclate();
        var result = calc.GetValue(cmd[1]);
        Messages.CurrentValue(cmd[1], result);
        Messages.ContinousPrompt();
        continue;
      }
      if (cmd.Length > 3)
      {
        Console.WriteLine("Invalid input");
        Messages.ContinousPrompt();
        continue;
      }
      Messages.ContinousPrompt();
      tr.GetTransaction(cmd, message, transactions, registerValue);
      continue;
    }
  }
}

