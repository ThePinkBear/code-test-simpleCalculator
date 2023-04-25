
namespace TransactionCalculator;

public static class Printer
{
  public static double GetValue(string register, Calculator calc)
  {
    return calc.GetRegisterValue(register);
  }
}