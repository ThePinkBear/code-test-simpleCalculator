namespace TransactionCalculator;

public class Calculator
{
  private Dictionary<string, double> _registerValue = new();
  private List<Transaction> _transactions = new();

  public Calculator(Dictionary<string, double> registerValue, List<Transaction> transactions)
  {
    _registerValue = registerValue;
    _transactions = transactions;
  }
  public double GetValue(string register)
  {
    return _registerValue[register];
  }
  public void Caluclate()
  {
    foreach (var transaction in _transactions)
    {
      DoCalculation(transaction);
    }
  }
  
  public void DoCalculation(Transaction transaction)
  {
    switch (transaction.Operation)
    {
      case Operation.Add:
        _registerValue[transaction.Register] = _registerValue[transaction.Register] + transaction.Value;
        break;
      case Operation.Subtract:
        _registerValue[transaction.Register] = _registerValue[transaction.Register] - transaction.Value;
        break;
      case Operation.Multiply:
        _registerValue[transaction.Register] = _registerValue[transaction.Register] * transaction.Value;
        break;
      default:
        throw new ArgumentException("Unsupported operation");
    }
  }
}