namespace SectraCalculator;

public class TransactionReader
{
  public List<Transaction> Extract(string path)
    {
      
      List<Transaction> transactions = new();
      
      using (StreamReader reader = new StreamReader(path))
      {
        string? line;
        while((line = reader.ReadLine()) != null)
        {
          if (line.ToLower() == "Quit") break;

          var transaction = line.Split(" ");

          if (transaction[0].ToLower() == "print") continue; //TODO Implement Printing functionality.
          transactions.Add(new Transaction()
          { 
            Register = transaction[0], 
            Operation = transaction[1] switch
            {
              "add"
                => Operation.Add,
              "subtract"
                => Operation.Subtract,
              "multiply"
                => Operation.Multiply,
              _
               => throw new ArgumentException("File not correctly formatted")
            },
            Value = Convert.ToDouble(transaction[2])
          });  
        }
        return transactions;
      }
    }
}