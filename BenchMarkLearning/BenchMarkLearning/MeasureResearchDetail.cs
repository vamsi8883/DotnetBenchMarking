

using System;

namespace BenchMarkLearning;

public class MeasureResearchDetail
{
    public MeasureResearchDetail()
    {
        YearDetails = new List<YearDetail>();
    }
    public int ProjectId { get; set; }
    public string? CountryCode { get; set; }
    public int ProductId { get; set; }
    public int DataTypeId { get; set; }
    public short DatasetId { get; set; }
    public int ChannelId { get; set; }
    public string? MeasureSubtype { get; set; }
    public double? MeasureBandMin { get; set; }
    public double? MeasureBandMax { get; set; }
    public int? UnitId { get; set; }
    public int? DataMetricId { get; set; }
    public long ResearchId { get; set; }
    public bool IsResearched { get; set; }
    public IList<YearDetail> YearDetails { get; set; }

    public MeasureResearchDetail Clone()
    {
        return new MeasureResearchDetail()
        {
            ProjectId = ProjectId,
            ChannelId = ChannelId,
            YearDetails = YearDetails,
            CountryCode = CountryCode,
            DataMetricId = DataMetricId,
            DataTypeId = DataTypeId,
            DatasetId=DatasetId,
            IsResearched = IsResearched,
            MeasureBandMax = MeasureBandMax,
            MeasureBandMin = MeasureBandMin,
            MeasureSubtype = MeasureSubtype,
            ProductId = ProductId,
            ResearchId = ResearchId,
            UnitId = UnitId
        };
    }
}
