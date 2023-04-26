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
    double value = 0;
    if(calCom.transaction.Value.Key != "")
    {
      value = _registerValue[calCom.transaction.Value.Key];
    }
    else
    {
      value = calCom.transaction.Value.Value;
    }
    
    switch (calCom.transaction?.Operation)
    {
      case Operation.Add:
        _registerValue[calCom.transaction.Register] = _registerValue[calCom.transaction.Register] + value;
        break;
      case Operation.Subtract:
        _registerValue[calCom.transaction.Register] = _registerValue[calCom.transaction.Register] - value;
        break;
      case Operation.Multiply:
        _registerValue[calCom.transaction.Register] = _registerValue[calCom.transaction.Register] * value;
        break;
      default:
        throw new ArgumentException("Unsupported operation");
    }
    return this;
  }
}