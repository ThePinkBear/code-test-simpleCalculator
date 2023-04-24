namespace SectraCalculator;

public class FileInput
{
  public void FileInputLogic(StreamReader reader, Calculator calc)
  {
    List<Transaction> transactions = new();
    TransactionCrafter tr = new();
    string[]? line;
    var message = "File transaction not correctly formatted";

    using (reader)
    {
      while ((line = reader.ReadLine()?.ToLower().Split(" ")) != null)
      {
        tr.GetTransaction(line, message, transactions, calc);
      }
    }
  }
}