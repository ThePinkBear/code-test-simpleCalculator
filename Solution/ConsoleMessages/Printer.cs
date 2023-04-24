using static SectraCalculator.CalculationCommand;

namespace SectraCalculator;

public static class Printer
{
  public static double Print(List<Transaction> transactions, string register)
  {
    var selected = transactions
      .Select(t => CalculationCommandFactory.CreateCalculationCommand(t));
      
    Calculator calc = new();
    foreach(var calcCommand in selected){
      calc.AddCalculation(calcCommand);
    }
    return calc.GetPendingCalculations(register);
  }
}