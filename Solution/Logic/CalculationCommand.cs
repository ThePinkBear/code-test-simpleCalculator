namespace SectraCalculator;

public class CalculationCommand
{
  public Transaction? transaction { get; private set; }

  private CalculationCommand(){}
  public static class CalculationCommandFactory
  {
    public static CalculationCommand CreateCalculationCommand(Transaction tra)
    {
      return new(){ transaction = tra };
    }
  }
}