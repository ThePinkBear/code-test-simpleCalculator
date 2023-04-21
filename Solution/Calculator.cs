using System.Linq;

public enum Operation {add, subtract, multiply}

public class CalculationCommand
{
  public Operation operation { get; private set; }
  public int[]? values { get; private set; }

  private CalculationCommand(){}
  public static class CalculationCommandFactory
  {
    public static CalculationCommand CreateCalculationCommand(Operation op, params int[] val)
    {
      return new(){operation = op, values = val};
    }
  }
}