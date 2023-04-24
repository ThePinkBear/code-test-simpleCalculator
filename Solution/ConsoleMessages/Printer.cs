
namespace SectraCalculator;

public static class Printer
{
  public static double Print(List<Transaction> transactions, string register)
  {
    Calculator calc = new();
    foreach(var transaction in transactions){
      calc.AddCalculation(transaction);
    }
    return calc.GetPendingCalculations(register);
  }
}