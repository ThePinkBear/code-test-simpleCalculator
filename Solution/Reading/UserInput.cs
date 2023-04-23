namespace SectraCalculator;

public class UserInput
{
  public void UserInputLogic()
  {
    Messages.Prompt();
    List<Transaction> transactions = new();
    TransactionCrafter tr = new();
    string[]? cmd;
    var message = "Available operations are: Add, Subtract & Multiply";
    while ((cmd = Console.ReadLine()?.ToLower().Split(" ")) != null)
    {
      if(cmd[0] == "") //TODO Format validation for user input
      {
        Messages.PressSomething();
        Thread.Sleep(1000);
        Messages.Prompt();
        continue;
      }
      Messages.Prompt();
      transactions.Add(tr.GetTransaction(cmd, message, transactions));
      continue;
    }
  }
}

