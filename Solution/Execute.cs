namespace SectraCalculator;

public class ExecuteStuff
{
  public void Execute(string line)
  {
    Dictionary<string, double> registers = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase);
    Dictionary<string, Func<double, double, double>> operations = new Dictionary<string, Func<double, double, double>>(StringComparer.OrdinalIgnoreCase)
    {
        { "add", (a, b) => a + b },
        { "subtract", (a, b) => a - b },
        { "multiply", (a, b) => a * b },
    };

    var parts = line.Split();
    if (parts.Length == 0) return;

    string command = parts[0].ToLowerInvariant();
    if (command == "print")
    {
      string register = parts[1];
      Console.WriteLine(registers.ContainsKey(register) ? registers[register] : 0);
    }
    else if (operations.ContainsKey(command))
    {
      string targetRegister = parts[1];
      string valueStr = parts[2];

      double value;
      if (double.TryParse(valueStr, out value))
      {
        registers[targetRegister] = operations[command](registers.ContainsKey(targetRegister) ? registers[targetRegister] : 0, value);
      }
      else
      {
        registers[targetRegister] = operations[command](registers.ContainsKey(targetRegister) ? registers[targetRegister] : 0, registers.ContainsKey(valueStr) ? registers[valueStr] : 0);
      }
    }
  }
}