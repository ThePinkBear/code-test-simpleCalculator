namespace TransactionCalculator;

public static class Printer
{
  public static double GetValue(List<Transaction> transactions, string register)
  {
    Calculator calculator = new();
    
    foreach (var transaction in transactions)
    {
      var calculationCommand = CalculationCommand
        .CalculationCommandFactory
        .CreateCalculationCommand(transaction);

      calculator.DoCalculation(calculationCommand);
    }
    return calculator.GetValue(register);
  }
}