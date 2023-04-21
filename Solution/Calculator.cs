namespace SectraCalculator;

public class Calculator
{
  private int _queuedCalculations;
  public int PendingCalculations() => _queuedCalculations;

  public Calculator AddCalculation(CalculationCommand calCom)
  {
    return calCom.operation switch
    {
      Operation.add
      => new(){_queuedCalculations = _queuedCalculations + calCom.values.Sum()},
      Operation.subtract
      => new(){_queuedCalculations = _queuedCalculations - calCom.values.Sum()},
      Operation.multiply
      => new(){_queuedCalculations = _queuedCalculations * calCom.values.Sum()},
      _
      => throw new ArgumentException("Unsupported operation")
    };
  }
}

public enum Operation {add, subtract, multiply}

public class CalculationCommand
{
  public Operation operation { get; private set; }
  public int[] values { get; private set; }

  private CalculationCommand(){}
  public static class CalculationCommandFactory
  {
    public static CalculationCommand CreateCalculationCommand(Operation op, params int[] val)
    {
      return new(){operation = op, values = val};
    }
  }
}