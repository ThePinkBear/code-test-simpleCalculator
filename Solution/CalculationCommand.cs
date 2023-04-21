namespace SectraCalculator;

public class CalculationCommand
{
  public Operation operation { get; private set; }
  public int value { get; private set; }
  public string register { get; private set; }

  private CalculationCommand(){}
  public static class CalculationCommandFactory
  {
    public static CalculationCommand CreateCalculationCommand(string reg, Operation op, int val)
    {
      return new(){register = reg, operation = op, value = val};
    }
  }
}