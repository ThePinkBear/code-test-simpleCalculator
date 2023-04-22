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
          if (line.ToLower() == "quit") break;

          var input = line.Split(" ");
          if (input[0].ToLower() == "print")
          {
            Messages.CurrentValue(input[1], Printer.Print(transactions, input[1]));
            continue;
          }
          double retrievedValue;
          var valueInput = input[2];
          if (double.TryParse(valueInput, out double value))
          {
            retrievedValue = value;
          }
          else
          {
            retrievedValue = Printer.Print(transactions, valueInput);
          }

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
            Value = retrievedValue
          });  
        }
        return transactions;
      }
    }
}