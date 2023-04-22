namespace SectraCalculator;

public class TransactionReader
{
  public List<Transaction> Extract(StreamReader reader)
    {
      
      List<Transaction> transactions = new();
      
      using (reader)
      {
        string? line;
        while((line = reader.ReadLine()) != null)
        {
          if (line.ToLower() == "Quit") break;

          var input = line.Split(" ");

          if (input[0].ToLower() == "print")
          {
            Printer.Print(transactions, input[1]);
          }
          transactions.Add(new Transaction()
          { 
            Register = input[0], 
            Operation = input[1] switch
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
            Value = Convert.ToDouble(input[2])
          });  
        }
        return transactions;
      }
    }
}