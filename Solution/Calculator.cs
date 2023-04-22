namespace SectraCalculator;

public class Calculator
{
  private double _queuedCalculations;

  public double GetPendingCalculations() => _queuedCalculations;
  public Calculator AddCalculation(CalculationCommand calCom)
  {
    return calCom.transaction!.Operation switch
    {
      Operation.Add
      => new(){_queuedCalculations = _queuedCalculations + calCom.transaction.Value},
      Operation.Subtract
      => new(){_queuedCalculations = _queuedCalculations - calCom.transaction.Value},
      Operation.Multiply
      => new(){_queuedCalculations = _queuedCalculations * calCom.transaction.Value},
      _
      => throw new ArgumentException("Unsupported operation")
    };
  }
}