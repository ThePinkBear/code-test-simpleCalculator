namespace SectraCalculator;

public class TransactionCrafter
{
  public Transaction GetTransaction(string[] input, string errorMessage, List<Transaction> transactions)
  {
    Transaction result = new();
    while(true)
    {
      if (input[0] == "quit")
      {
        Environment.Exit(0);
      }
      if (input[0] == "print")
      {
        Messages.CurrentValue(input[1], Printer.Print(transactions, input[1]));
        return result;
      }

      string register = input[0];

      var operatorInput = input[1];

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
          Messages.OperatorErrorMessage();
          continue;
      };

      var valueInput = input[2];
      if (double.TryParse(valueInput, out double value))
      {
        result = new()
        {
          Register = register,
          Operation = operation,
          Value = value
        };
        return result;
      }
      else
      {
        result = new()
        {
          Register = register,
          Operation = operation,
          Value = Printer.Print(transactions, valueInput!)
        };
        return result;
      }
    }
  }
  
}