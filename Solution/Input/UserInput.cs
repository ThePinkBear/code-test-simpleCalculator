namespace TransactionCalculator;

public class UserInput
{

  public void UserInputLogic()
  {
    Messages.Prompt();
    List<Transaction> transactions = new();
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
        if(cmd.Length < 2)
        {
          Console.WriteLine("Invalid input");
          Messages.ContinousPrompt();
          continue;
        }
        Messages.CurrentValue(cmd[1], Printer.GetValue(transactions, cmd[1]));
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
      tr.CreateTransaction(cmd, message, transactions);
      continue;
    }
  }
}

