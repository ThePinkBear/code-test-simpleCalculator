namespace TransactionCalculator;

public class Calculator
{
  private Dictionary<string, double> _registerValue = new();

  public double GetValue(string register) => _registerValue[register];

  public Calculator DoCalculation(CalculationCommand calCom)
  {
    if (!_registerValue.ContainsKey(calCom.transaction!.Register))
    {
      _registerValue.Add(calCom.transaction.Register, 0);
    }
    
    var value = calCom.transaction.Value.Key != "" ? 
      _registerValue[calCom.transaction.Value.Key] :
      calCom.transaction.Value.Value;
    
    // Console.WriteLine($"Register: {calCom.transaction.Register} Operation: {calCom.transaction.Operation} ValueKey: {calCom.transaction.Value.Key} ValueValue: {value}");
    
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