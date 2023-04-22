using System.Collections.Generic;

namespace SectraCalculator;
public class Transaction
{
    public string Register { get; set; } = "";
    public Operation Operation { get; set; }
    public double Value { get; set; }
}