using static SectraCalculator.CalculationCommand;

namespace SectraCalculator;

public static class Printer
{
  public static void Print(List<Transaction> transactions, string register)
  {
    var selected = transactions
      .Where(t => t.Register == register)
      .Select(t => CalculationCommandFactory.CreateCalculationCommand(t));
      
    Calculator calc = new();
    foreach(var calcCommand in selected){
      calc.AddCalculation(calcCommand);
    }
    var result = calc.GetPendingCalculations(register);
    Messages.CurrentValue(register, result);
  }
}