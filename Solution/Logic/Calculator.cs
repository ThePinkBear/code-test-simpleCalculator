namespace SectraCalculator;

public class Calculator
{
  private Dictionary<string, double> _queuedCalculations = new();

  public double GetPendingCalculations(string key) => _queuedCalculations[key];
  public Calculator AddCalculation(Transaction transaction)
  {
    if (!_queuedCalculations.ContainsKey(transaction!.Register))
    {
      _queuedCalculations.Add(transaction.Register, 0.0);
    }

    switch (transaction.Operation)
    {
      case Operation.Add:
        _queuedCalculations[transaction.Register] += transaction.Value;
        break;
      case Operation.Subtract:
        _queuedCalculations[transaction.Register] -= transaction.Value;
        break;
      case Operation.Multiply:
        _queuedCalculations[transaction.Register] *= transaction.Value;
        break;
      default:
        throw new ArgumentException("Unsupported operation");
    }

    return this;
  }
}