namespace TransactionCalculator;

public class Calculator
{
  private Dictionary<string, double> _queuedCalculations = new();
  public List<Transaction> transactions = new();
  public void AddRegister(string reg, double val)
  {
    if(!_queuedCalculations.ContainsKey(reg))
    {
      _queuedCalculations.Add(reg, 0.0);
    }
  }

  public double GetPendingCalculations(string key) => _queuedCalculations.ContainsKey(key)? _queuedCalculations[key]: 0.0;
  public void AddCalculation(Transaction transaction)
  {
    switch (transaction.Operation)
    {
      case Operation.Add:
        _queuedCalculations[transaction.Register] = _queuedCalculations[transaction.Register] + transaction.Value;
        break;
      case Operation.Subtract:
        _queuedCalculations[transaction.Register] = _queuedCalculations[transaction.Register] - transaction.Value;
        break;
      case Operation.Multiply:
        _queuedCalculations[transaction.Register] = _queuedCalculations[transaction.Register] * transaction.Value;
        break;
      default:
        throw new ArgumentException("Unsupported operation");
    }
  }
}