namespace SectraCalculator;

public class FileInput
{
  public void FileInputLogic(StreamReader reader, Calculator calc)
  {
    TransactionCrafter tr = new();
    string[]? line;
    var message = "File transaction not correctly formatted";

    using (reader)
    {
      while ((line = reader.ReadLine()?.ToLower().Split(" ")) != null)
      {
      }
    }
  }
}