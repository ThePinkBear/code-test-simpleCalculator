
namespace TransactionCalculator;

public static class Printer
{
  public static double GetValue(string register, Dictionary<string, double> registerValue)
  {
    return registerValue[register];
  }
}