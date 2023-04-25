namespace TransactionCalculator;

public class TransactionCrafter
{
  public void GetTransaction(string[] input, string errorMessage, List<Transaction> transactions, Dictionary<string, double> registerValue)
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
        if(!registerValue.ContainsKey(registerInput))
        {
          registerValue.Add(registerInput, 0.0);
        }

        result = new()
        {
          Register = registerInput,
          Operation = operation,
          Value = value
        };
        transactions.Insert(0, result);
        break;
      }
      else
      {
        if(!registerValue.ContainsKey(valueInput))
        {
          registerValue.Add(valueInput, 0.0);
        }
        result = new()
        {
          Register = valueInput,
          Operation = operation,
          Value = registerValue.ContainsKey(valueInput) ? registerValue[valueInput] : 0.0
        };
        transactions.Add(result);
        break;
      }
    }
  }
}