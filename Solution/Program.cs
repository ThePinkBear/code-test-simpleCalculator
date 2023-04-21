using SectraCalculator;
using static SectraCalculator.CalculationCommand;

Console.WriteLine("Input register");
string register = Console.ReadLine()!;

Console.WriteLine("input operationtype; Add, Subtract or Multiply");
Operation operation = Console
  .ReadLine().ToLower() switch
    {
      "add" 
        => Operation.Add,
      "subtract" 
        => Operation.Subtract,
      "multiply" 
        => Operation.Multiply,
      _ 
      => throw new ArgumentException("Unsupported operation type")
    };

Console.WriteLine("Input numeric value");
int value = int.Parse(Console.ReadLine()!);

var cmd = CalculationCommandFactory.CreateCalculationCommand(register, operation, value);
Calculator calc = new();
calc.AddCalculation(cmd);

Console.WriteLine($"Register: {cmd.register}, Operation: {cmd.operation}, Value: {cmd.value},");

Console.WriteLine("Result:");
Console.WriteLine(calc.GetPendingCalculations());
Console.ReadLine();
