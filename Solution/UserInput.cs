namespace SectraCalculator;

public class UserInput
{
  public void UserInputLogic()
  {
    List<Transaction> transactions = new();
        
      while (true)
      {
        Messages.Prompt();

        var cmd = Console.ReadLine()!.Split(" ");
        if (cmd[0].ToLower() == "quit")
        {
          Environment.Exit(0);
        }
        if (cmd[0].ToLower() == "print")
        {
          Printer.Print(transactions, cmd[1]);
          continue;
        }
        
        Messages.InputRegister();
        string register = Console.ReadLine()!;

        Messages.InputOperator();
        var input = Console.ReadLine()?.ToLower();

        Operation operation;

        switch (input)
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

        Messages.InputNumeric();
        int value = int.Parse(Console.ReadLine()!);
        
        transactions.Add( new()
        {
          Register = register,
          Operation = operation,
          Value = value
        });
        continue;
      }
    }
}

