namespace TransactionCalculator;

public class TransactionCrafter
{
  public void CreateTransaction(string[] input, List<Transaction> transactions, List<Transaction> relationTransactions)
  {
    Transaction result = new();
    
      string registerInput = input[0];

      Operation operatorInput = input[1] switch
      {
        "add" 
          => Operation.Add,
        "subtract" 
          => Operation.Subtract,
        "multiply" 
          => Operation.Multiply,
          _
          => throw new ArgumentException("Invalid input")
      };

      var valueInput = input[2];
      
      if (double.TryParse(valueInput, out double value))
      {
        result = new()
        {
          Register = registerInput,
          Operation = operatorInput,
          Value = new KeyValuePair<string, double>("", value)
        };
        transactions.Add(result);
      }
      else
      {
        result = new()
        {
          Register = registerInput,
          Operation = operatorInput,
          Value = new KeyValuePair<string, double>(valueInput, 0)
        };
        
        relationTransactions.Add(result);
      }
    
  }
}