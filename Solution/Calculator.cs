namespace SectraCalculator;

public class Calculator
{
  private int _queuedCalculations;

  public int GetPendingCalculations() => _queuedCalculations;
  public Calculator AddCalculation(CalculationCommand calCom)
  {
    return calCom.operation switch
    {
      Operation.Add
      => new(){_queuedCalculations = _queuedCalculations + calCom.value},
      Operation.Subtract
      => new(){_queuedCalculations = _queuedCalculations - calCom.value},
      Operation.Multiply
      => new(){_queuedCalculations = _queuedCalculations * calCom.value},
      _
      => throw new ArgumentException("Unsupported operation")
    };
  }
}