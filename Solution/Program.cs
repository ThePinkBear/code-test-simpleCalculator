using SectraCalculator;

internal class Program
{
  public static void Main(string[] args)
    {
        var calculator = new TransactionFileExtractor();
        if (args.Length == 1)
        {
            using (var file = new StreamReader(args[0]))
            {
                calculator.Run(file);
            }
        }
        else
        {
            calculator.Run(Console.In);
        }
    }
}