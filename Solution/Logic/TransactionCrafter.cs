namespace SectraCalculator;

public class TransactionCrafter
{
  public Transaction GetTransaction(string[] input, string errorMessage, List<Transaction> transactions, Calculator calc)
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
          Value = value
        };
        calc.AddRegister(registerInput, value);
        return result;
      }
      else
      {
        result = new()
        {
          Register = valueInput,
          Operation = operation,
          Value = calc.GetPendingCalculations(registerInput)
        };
        return result;
      }
    }
  }
}