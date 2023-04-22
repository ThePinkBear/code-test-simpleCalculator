namespace SectraCalculator;

public class Calculator
{
  private Dictionary<string, double> _queuedCalculations = new();

  public double GetPendingCalculations(string key) => _queuedCalculations[key];
  public Calculator AddCalculation(CalculationCommand calCom)
  {
    if (!_queuedCalculations.ContainsKey(calCom.transaction!.Register))
    {
      _queuedCalculations.Add(calCom.transaction.Register, 0.0);
    }

    switch (calCom.transaction.Operation)
    {
      case Operation.Add:
        _queuedCalculations[calCom.transaction.Register] += calCom.transaction.Value;
        break;
      case Operation.Subtract:
        _queuedCalculations[calCom.transaction.Register] -= calCom.transaction.Value;
        break;
      case Operation.Multiply:
        _queuedCalculations[calCom.transaction.Register] *= calCom.transaction.Value;
        break;
      default:
        throw new ArgumentException("Unsupported operation");
    }

    return this;
  }
}