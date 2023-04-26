using static TransactionCalculator.CalculationCommand;

namespace TransactionCalculator;

public class Calculator
{
  private Dictionary<string, double> _registerValue = new();

  public double GetValue(string register)
  {
    return _registerValue[register];
  }
  
  public Calculator DoCalculation(CalculationCommand calCom)
  {
    if (!_registerValue.ContainsKey(calCom.transaction!.Register))
    {
      _registerValue.Add(calCom.transaction.Register, 0);
    }
    
    switch (calCom.transaction?.Operation)
    {
      case Operation.Add:
        _registerValue[calCom.transaction.Register] = _registerValue[calCom.transaction.Register] + calCom.transaction.Value;
        break;
      case Operation.Subtract:
        _registerValue[calCom.transaction.Register] = _registerValue[calCom.transaction.Register] - calCom.transaction.Value;
        break;
      case Operation.Multiply:
        _registerValue[calCom.transaction.Register] = _registerValue[calCom.transaction.Register] * calCom.transaction.Value;
        break;
      default:
        throw new ArgumentException("Unsupported operation");
    }
    return this;
  }
}