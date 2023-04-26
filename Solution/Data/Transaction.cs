namespace TransactionCalculator;
public class Transaction
{
    public string Register { get; set; } = "";
    public Operation Operation { get; set; }
    public KeyValuePair<string,double> Value { get; set; }
}