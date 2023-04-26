namespace TransactionCalculator;

public class UserInput
{

  public void UserInputLogic()
  {
    Messages.Prompt();
    List<Transaction> transactions = new();
    List<Transaction> relationTransactions = new();

    TransactionCrafter tr = new();
    string[]? input;
    while ((input = Console.ReadLine()?.ToLower().Split(" ")) != null)
    {
      if (input[0] == "")
      {
        Messages.PressSomething();
        Thread.Sleep(1000);
        Messages.ContinousPrompt();
        continue;
      }

      if (input[0] == "quit")
      {
        Messages.AppEnd();
        Thread.Sleep(1000);
        Environment.Exit(0);
      }
      if (input[0] == "print")
      {
        foreach(var relationTransaction in relationTransactions)
        {
          transactions.Add(relationTransaction);
        }
        if(input.Length < 2)
        {
          Console.WriteLine("Invalid input");
          Messages.ContinousPrompt();
          continue;
        }
        Messages.CurrentValue(input[1], Printer.GetValue(transactions, input[1]));
        Messages.ContinousPrompt();
        continue;
      }
      if (input.Length > 3)
      {
        Console.WriteLine("Invalid input");
        Messages.ContinousPrompt();
        continue;
      }
      tr.CreateTransaction(input, transactions, relationTransactions);
      Messages.ContinousPrompt();
      continue;
    }
  }
}

