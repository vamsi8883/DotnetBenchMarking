namespace BenchMarkLearning;

public class YearDetail
{
    public int Year { get; set; }
    public double? Value { get; set; }

    public YearDetail Clone()
    {
        return new YearDetail()
        {
            Value = Value,
            Year = Year
        };
    }
}