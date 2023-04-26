namespace TransactionCalculator;

public class TransactionCrafter
{
  public void CreateTransaction(string[] input, string errorMessage, List<Transaction> transactions)
  {

    Transaction result = new();
    while(true)
    {
      string registerInput = input[0];

      var operatorInput = input[1];

      var valueInput = input[2];
      
      Operation operation;

      switch (operatorInput)
      {
        case "add":
          operation = Operation.Add;
          break;
        case "subtract":
          operation = Operation.Subtract;
          break;
        case "multiply":
          operation = Operation.Multiply;
          break;
        default:
          Messages.OperatorErrorMessage(errorMessage);
          continue;
      };

      if (double.TryParse(valueInput, out double value))
      {
        result = new()
        {
          Register = registerInput,
          Operation = operation,
          Value = new KeyValuePair<string, double>("", value)
        };
        transactions.Insert(0, result);
        break;
      }
      else
      {
        result = new()
        {
          Register = registerInput,
          Operation = operation,
          Value = new KeyValuePair<string, double>(valueInput, 0)
        };
        transactions.Add(result);
        
        break;
      }
    }
  }
}