namespace TransactionCalculator;

public class TransactionCrafter
{
  public void CreateTransaction(string[] input, string errorMessage, List<Transaction> transactions, List<Transaction> relationTransactions)
  {
    Transaction result = new();
    while(true)
    {
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
          => throw new ArgumentException(errorMessage)
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
        break;
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
        break;
      }
    }
  }
}