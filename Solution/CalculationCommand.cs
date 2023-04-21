namespace SectraCalculator;

public class CalculationCommand
{
  public Operation operation { get; private set; }
  public int value { get; private set; }

  private CalculationCommand(){}
  public static class CalculationCommandFactory
  {
    public static CalculationCommand CreateCalculationCommand(Operation op, int val)
    {
      return new(){operation = op, value = val};
    }
  }
}