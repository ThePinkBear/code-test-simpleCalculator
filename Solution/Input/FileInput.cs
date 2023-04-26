namespace TransactionCalculator;

public class FileInput
{
  public void FileInputLogic(StreamReader reader)
  {
    List<Transaction> transactions = new();
    List<Transaction> relationTransactions = new();
    TransactionCrafter tr = new();
    string[]? line;

    using (reader)
    {
      while ((line = reader.ReadLine()?.ToLower().Split(" ")) != null)
      {
        if (line[0] == "")
      {
        Messages.PressSomething();
        Thread.Sleep(1000);
        Messages.ContinousPrompt();
        continue;
      }

      if (line[0] == "quit")
      {
        Messages.AppEnd();
        Thread.Sleep(1000);
        Environment.Exit(0);
      }
      if (line[0] == "print")
      {
        foreach(var relationTransaction in relationTransactions)
        {
          transactions.Add(relationTransaction);
        }
        if(line.Length < 2)
        {
          Console.WriteLine("Invalid input");
          Messages.ContinousPrompt();
          continue;
        }
        Messages.CurrentValue(line[1], Printer.GetValue(transactions, line[1]));
        Messages.ContinousPrompt();
        continue;
      }
      if (line.Length > 3)
      {
        Console.WriteLine("Invalid input");
        Messages.ContinousPrompt();
        continue;
      }
        tr.CreateTransaction(line, transactions, relationTransactions);
      }
    }
  }
}