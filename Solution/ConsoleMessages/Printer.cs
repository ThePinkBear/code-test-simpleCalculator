namespace TransactionCalculator;

public static class Printer
{
  public static double GetValue(List<Transaction> transactions, string register)
  {
    var calc = new Calculator();
    foreach (var transaction in transactions)
    {
      var calCom = CalculationCommand.CalculationCommandFactory.CreateCalculationCommand(transaction);
      calc.DoCalculation(calCom);
    }
    return calc.GetValue(register);
  }
}