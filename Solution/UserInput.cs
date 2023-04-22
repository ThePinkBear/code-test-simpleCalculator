namespace SectraCalculator;

public class UserInput
{
  public Transaction UserInputLogic()
  {
    List<Transaction> transactions = new();

    Console.WriteLine("Input register");
    string register = Console.ReadLine()!;

    Console.WriteLine("input operationtype; Add, Subtract or Multiply");
  
    Operation operation;
    while(true)
    { 
      var input = Console.ReadLine()?.ToLower();
      switch(input)
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
          Console.WriteLine("Unsupported operation type.");
          Console.WriteLine("Please input either: Add, Subtract or Multiply.");
          continue;
      };
      break;
    }
    Console.WriteLine("Input numeric value");
    int value = int.Parse(Console.ReadLine()!);

    return new()
    {
      Register = register,
      Operation = operation,
      Value = value
    };

  }
}

