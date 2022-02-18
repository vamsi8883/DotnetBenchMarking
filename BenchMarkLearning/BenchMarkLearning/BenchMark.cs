
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Jobs;
using Force.DeepCloner;

namespace BenchMarkLearning;

[MemoryDiagnoser]
[SimpleJob(runtimeMoniker: RuntimeMoniker.Net60, baseline: true)]
public class BenchMark
{

    //[Benchmark]
    //public void test()
    //{
    //    var dd = new MeasureResearchDetail()
    //    {
    //        ProjectId = 670,
    //        CountryCode = "GB",
    //        ProductId = 7253,
    //        DataTypeId = 913,
    //        DatasetId = 458,
    //        ChannelId = 2378,
    //        MeasureSubtype = "Citric Acid",
    //        MeasureBandMin = null,
    //        MeasureBandMax = null,
    //        UnitId = null,
    //        YearDetails =
    //        {
    //            new YearDetail {Year = 2006, Value = 132.5168747},
    //            new YearDetail {Year = 2007, Value = 130.8021296},
    //            new YearDetail {Year = 2008, Value = 130.5171577},
    //            new YearDetail {Year = 2009, Value = 132.2269894},
    //            new YearDetail {Year = 2010, Value = 133.1958941},
    //            new YearDetail {Year = 2011, Value = 132.1414979},
    //            new YearDetail {Year = 2012, Value = 132.6919022},
    //            new YearDetail {Year = 2013, Value = 136.342173},
    //            new YearDetail {Year = 2014, Value = 138.0821219},
    //            new YearDetail {Year = 2015, Value = 140.4126283},
    //            new YearDetail {Year = 2016, Value = 143.1129183},
    //            new YearDetail {Year = 2017, Value = 146.3846292},
    //            new YearDetail {Year = 2018, Value = 151.8938749},
    //            new YearDetail {Year = 2019, Value = 156.0052634},
    //            new YearDetail {Year = 2020, Value = 146.6080707},
    //            new YearDetail {Year = 2021, Value = 152.7817528},
    //            new YearDetail {Year = 2022, Value = 158.8514672},
    //            new YearDetail {Year = 2023, Value = 164.53223},
    //            new YearDetail {Year = 2024, Value = 168.8152812},
    //            new YearDetail {Year = 2025, Value = 170.2342669},

    //        },
    //        DataMetricId = 2,

    //    };
    //    var dd1 = new MeasureResearchDetail()
    //    {
    //        ProjectId = 670,
    //        CountryCode = "GB",
    //        ProductId = 7253,
    //        DataTypeId = 913,
    //        DatasetId = 458,
    //        ChannelId = 2378,
    //        MeasureSubtype = "Citric Acid",
    //        MeasureBandMin = null,
    //        MeasureBandMax = null,
    //        UnitId = null,
    //        YearDetails =
    //        {
    //            new YearDetail {Year = 2006, Value = 0.27748},
    //            new YearDetail {Year = 2007, Value = 0.27748},
    //            new YearDetail {Year = 2008, Value = 0.27748},
    //            new YearDetail {Year = 2009, Value = 0.27748},
    //            new YearDetail {Year = 2010, Value = 0.27748},
    //            new YearDetail {Year = 2011, Value = 0.27748},
    //            new YearDetail {Year = 2012, Value = 0.27748},
    //            new YearDetail {Year = 2013, Value = 0.27748},
    //            new YearDetail {Year = 2014, Value = 0.27748},
    //            new YearDetail {Year = 2015, Value = 0.27748},
    //            new YearDetail {Year = 2016, Value = 0.27748},
    //            new YearDetail {Year = 2017, Value = 0.27748},
    //            new YearDetail {Year = 2018, Value = 0.28648},
    //            new YearDetail {Year = 2019, Value = 0.28648},
    //            new YearDetail {Year = 2020, Value = 0.28648},
    //            new YearDetail {Year = 2021, Value = 0.28648},
    //            new YearDetail {Year = 2022, Value = 0.28648},
    //            new YearDetail {Year = 2023, Value = 0.28648},
    //            new YearDetail {Year = 2024, Value = 0.28648},
    //            new YearDetail {Year = 2025, Value = 0.28648},

    //        },
    //        DataMetricId = 1,
    //    };

    //    var list = new List<YearDetail>();
    //    foreach (var one in dd1.YearDetails)
    //    {
    //        var ddd = dd.YearDetails.FirstOrDefault(x => x.Year == one.Year);
    //        list.Add(new YearDetail()
    //        {
    //            Year = one.Year,
    //            Value = GetActualYearValue(one.Value, ddd.Value, 1000)
    //        });
    //    }
    //}

    //[Benchmark]
    //public void test1()
    //{
    //    var dd = new MeasureResearchDetail()
    //    {
    //        ProjectId = 670,
    //        CountryCode = "GB",
    //        ProductId = 7253,
    //        DataTypeId = 913,
    //        DatasetId = 458,
    //        ChannelId = 2378,
    //        MeasureSubtype = "Citric Acid",
    //        MeasureBandMin = null,
    //        MeasureBandMax = null,
    //        UnitId = null,
    //        YearDetails =
    //        {
    //            new YearDetail {Year = 2006, Value = 132.5168747},
    //            new YearDetail {Year = 2007, Value = 130.8021296},
    //            new YearDetail {Year = 2008, Value = 130.5171577},
    //            new YearDetail {Year = 2009, Value = 132.2269894},
    //            new YearDetail {Year = 2010, Value = 133.1958941},
    //            new YearDetail {Year = 2011, Value = 132.1414979},
    //            new YearDetail {Year = 2012, Value = 132.6919022},
    //            new YearDetail {Year = 2013, Value = 136.342173},
    //            new YearDetail {Year = 2014, Value = 138.0821219},
    //            new YearDetail {Year = 2015, Value = 140.4126283},
    //            new YearDetail {Year = 2016, Value = 143.1129183},
    //            new YearDetail {Year = 2017, Value = 146.3846292},
    //            new YearDetail {Year = 2018, Value = 151.8938749},
    //            new YearDetail {Year = 2019, Value = 156.0052634},
    //            new YearDetail {Year = 2020, Value = 146.6080707},
    //            new YearDetail {Year = 2021, Value = 152.7817528},
    //            new YearDetail {Year = 2022, Value = 158.8514672},
    //            new YearDetail {Year = 2023, Value = 164.53223},
    //            new YearDetail {Year = 2024, Value = 168.8152812},
    //            new YearDetail {Year = 2025, Value = 170.2342669},

    //        },
    //        DataMetricId = 2,

    //    };
    //    var dd1 = new MeasureResearchDetail()
    //    {
    //        ProjectId = 670,
    //        CountryCode = "GB",
    //        ProductId = 7253,
    //        DataTypeId = 913,
    //        DatasetId = 458,
    //        ChannelId = 2378,
    //        MeasureSubtype = "Citric Acid",
    //        MeasureBandMin = null,
    //        MeasureBandMax = null,
    //        UnitId = null,
    //        YearDetails =
    //        {
    //            new YearDetail {Year = 2006, Value = 0.27748},
    //            new YearDetail {Year = 2007, Value = 0.27748},
    //            new YearDetail {Year = 2008, Value = 0.27748},
    //            new YearDetail {Year = 2009, Value = 0.27748},
    //            new YearDetail {Year = 2010, Value = 0.27748},
    //            new YearDetail {Year = 2011, Value = 0.27748},
    //            new YearDetail {Year = 2012, Value = 0.27748},
    //            new YearDetail {Year = 2013, Value = 0.27748},
    //            new YearDetail {Year = 2014, Value = 0.27748},
    //            new YearDetail {Year = 2015, Value = 0.27748},
    //            new YearDetail {Year = 2016, Value = 0.27748},
    //            new YearDetail {Year = 2017, Value = 0.27748},
    //            new YearDetail {Year = 2018, Value = 0.28648},
    //            new YearDetail {Year = 2019, Value = 0.28648},
    //            new YearDetail {Year = 2020, Value = 0.28648},
    //            new YearDetail {Year = 2021, Value = 0.28648},
    //            new YearDetail {Year = 2022, Value = 0.28648},
    //            new YearDetail {Year = 2023, Value = 0.28648},
    //            new YearDetail {Year = 2024, Value = 0.28648},
    //            new YearDetail {Year = 2025, Value = 0.28648},

    //        },
    //        DataMetricId = 1,
    //    };

    //    var list = (from measureYearDetail in dd.YearDetails
    //        join sizeYearDetail in dd1.YearDetails
    //            on new
    //            {
    //                measureYearDetail.Year
    //            }
    //            equals new
    //            {
    //                sizeYearDetail.Year
    //            }
    //        select new YearDetail
    //        {
    //            Year = measureYearDetail.Year,
    //            Value = GetActualYearValue(Convert.ToDouble(measureYearDetail.Value), Convert.ToDouble(sizeYearDetail.Value), 10000)
    //        }).ToList();
    //}

    //[Benchmark]
    //public void test2()
    //{
    //    var somethings = new List<MeasureResearchDetail>()
    //    {
    //        new MeasureResearchDetail()
    //        {
    //            ProjectId = 670,
    //            CountryCode = "GB",
    //            ProductId = 7253,
    //            DataTypeId = 913,
    //            DatasetId = 458,
    //            ChannelId = 2378,
    //            MeasureSubtype = "Citric Acid",
    //            MeasureBandMin = null,
    //            MeasureBandMax = null,
    //            UnitId = null,
    //            YearDetails =
    //            {
    //                new YearDetail {Year = 2006, Value = 132.5168747},
    //                new YearDetail {Year = 2007, Value = 130.8021296},
    //                new YearDetail {Year = 2008, Value = 130.5171577},
    //                new YearDetail {Year = 2009, Value = 132.2269894},
    //                new YearDetail {Year = 2010, Value = 133.1958941},
    //                new YearDetail {Year = 2011, Value = 132.1414979},
    //                new YearDetail {Year = 2012, Value = 132.6919022},
    //                new YearDetail {Year = 2013, Value = 136.342173},
    //                new YearDetail {Year = 2014, Value = 138.0821219},
    //                new YearDetail {Year = 2015, Value = 140.4126283},
    //                new YearDetail {Year = 2016, Value = 143.1129183},
    //                new YearDetail {Year = 2017, Value = 146.3846292},
    //                new YearDetail {Year = 2018, Value = 151.8938749},
    //                new YearDetail {Year = 2019, Value = 156.0052634},
    //                new YearDetail {Year = 2020, Value = 146.6080707},
    //                new YearDetail {Year = 2021, Value = 152.7817528},
    //                new YearDetail {Year = 2022, Value = 158.8514672},
    //                new YearDetail {Year = 2023, Value = 164.53223},
    //                new YearDetail {Year = 2024, Value = 168.8152812},
    //                new YearDetail {Year = 2025, Value = 170.2342669},

    //            },
    //            DataMetricId = 2,

    //        },
    //        new MeasureResearchDetail()
    //        {
    //            ProjectId = 670,
    //            CountryCode = "GB",
    //            ProductId = 7253,
    //            DataTypeId = 913,
    //            DatasetId = 458,
    //            ChannelId = 2378,
    //            MeasureSubtype = "Citric Acid",
    //            MeasureBandMin = null,
    //            MeasureBandMax = null,
    //            UnitId = null,
    //            YearDetails =
    //            {
    //                new YearDetail {Year = 2006, Value = 0.27748},
    //                new YearDetail {Year = 2007, Value = 0.27748},
    //                new YearDetail {Year = 2008, Value = 0.27748},
    //                new YearDetail {Year = 2009, Value = 0.27748},
    //                new YearDetail {Year = 2010, Value = 0.27748},
    //                new YearDetail {Year = 2011, Value = 0.27748},
    //                new YearDetail {Year = 2012, Value = 0.27748},
    //                new YearDetail {Year = 2013, Value = 0.27748},
    //                new YearDetail {Year = 2014, Value = 0.27748},
    //                new YearDetail {Year = 2015, Value = 0.27748},
    //                new YearDetail {Year = 2016, Value = 0.27748},
    //                new YearDetail {Year = 2017, Value = 0.27748},
    //                new YearDetail {Year = 2018, Value = 0.28648},
    //                new YearDetail {Year = 2019, Value = 0.28648},
    //                new YearDetail {Year = 2020, Value = 0.28648},
    //                new YearDetail {Year = 2021, Value = 0.28648},
    //                new YearDetail {Year = 2022, Value = 0.28648},
    //                new YearDetail {Year = 2023, Value = 0.28648},
    //                new YearDetail {Year = 2024, Value = 0.28648},
    //                new YearDetail {Year = 2025, Value = 0.28648},

    //            },
    //            DataMetricId = 1,
    //        }
    //    };

    //    var dd = somethings.DeepClone();
    //}


    [Benchmark]
    public void test3()
    {
        var somethings = new List<MeasureResearchDetail>()
        {
            new MeasureResearchDetail()
            {
                ProjectId = 670,
                CountryCode = "GB",
                ProductId = 7253,
                DataTypeId = 913,
                DatasetId = 458,
                ChannelId = 2378,
                MeasureSubtype = "Citric Acid",
                MeasureBandMin = null,
                MeasureBandMax = null,
                UnitId = null,
                YearDetails =
                {
                    new YearDetail {Year = 2006, Value = 132.5168747},
                    new YearDetail {Year = 2007, Value = 130.8021296},
                    new YearDetail {Year = 2008, Value = 130.5171577},
                    new YearDetail {Year = 2009, Value = 132.2269894},
                    new YearDetail {Year = 2010, Value = 133.1958941},
                    new YearDetail {Year = 2011, Value = 132.1414979},
                    new YearDetail {Year = 2012, Value = 132.6919022},
                    new YearDetail {Year = 2013, Value = 136.342173},
                    new YearDetail {Year = 2014, Value = 138.0821219},
                    new YearDetail {Year = 2015, Value = 140.4126283},
                    new YearDetail {Year = 2016, Value = 143.1129183},
                    new YearDetail {Year = 2017, Value = 146.3846292},
                    new YearDetail {Year = 2018, Value = 151.8938749},
                    new YearDetail {Year = 2019, Value = 156.0052634},
                    new YearDetail {Year = 2020, Value = 146.6080707},
                    new YearDetail {Year = 2021, Value = 152.7817528},
                    new YearDetail {Year = 2022, Value = 158.8514672},
                    new YearDetail {Year = 2023, Value = 164.53223},
                    new YearDetail {Year = 2024, Value = 168.8152812},
                    new YearDetail {Year = 2025, Value = 170.2342669},

                },
                DataMetricId = 2,

            },
            new MeasureResearchDetail()
            {
                ProjectId = 670,
                CountryCode = "GB",
                ProductId = 7253,
                DataTypeId = 913,
                DatasetId = 458,
                ChannelId = 2378,
                MeasureSubtype = "Citric Acid",
                MeasureBandMin = null,
                MeasureBandMax = null,
                UnitId = null,
                YearDetails =
                {
                    new YearDetail {Year = 2006, Value = 0.27748},
                    new YearDetail {Year = 2007, Value = 0.27748},
                    new YearDetail {Year = 2008, Value = 0.27748},
                    new YearDetail {Year = 2009, Value = 0.27748},
                    new YearDetail {Year = 2010, Value = 0.27748},
                    new YearDetail {Year = 2011, Value = 0.27748},
                    new YearDetail {Year = 2012, Value = 0.27748},
                    new YearDetail {Year = 2013, Value = 0.27748},
                    new YearDetail {Year = 2014, Value = 0.27748},
                    new YearDetail {Year = 2015, Value = 0.27748},
                    new YearDetail {Year = 2016, Value = 0.27748},
                    new YearDetail {Year = 2017, Value = 0.27748},
                    new YearDetail {Year = 2018, Value = 0.28648},
                    new YearDetail {Year = 2019, Value = 0.28648},
                    new YearDetail {Year = 2020, Value = 0.28648},
                    new YearDetail {Year = 2021, Value = 0.28648},
                    new YearDetail {Year = 2022, Value = 0.28648},
                    new YearDetail {Year = 2023, Value = 0.28648},
                    new YearDetail {Year = 2024, Value = 0.28648},
                    new YearDetail {Year = 2025, Value = 0.28648},

                },
                DataMetricId = 1,
            },new MeasureResearchDetail()
            {
                ProjectId = 670,
                CountryCode = "GB",
                ProductId = 7253,
                DataTypeId = 913,
                DatasetId = 458,
                ChannelId = 2378,
                MeasureSubtype = "Citric Acid",
                MeasureBandMin = null,
                MeasureBandMax = null,
                UnitId = null,
                YearDetails =
                {
                    new YearDetail {Year = 2006, Value = 132.5168747},
                    new YearDetail {Year = 2007, Value = 130.8021296},
                    new YearDetail {Year = 2008, Value = 130.5171577},
                    new YearDetail {Year = 2009, Value = 132.2269894},
                    new YearDetail {Year = 2010, Value = 133.1958941},
                    new YearDetail {Year = 2011, Value = 132.1414979},
                    new YearDetail {Year = 2012, Value = 132.6919022},
                    new YearDetail {Year = 2013, Value = 136.342173},
                    new YearDetail {Year = 2014, Value = 138.0821219},
                    new YearDetail {Year = 2015, Value = 140.4126283},
                    new YearDetail {Year = 2016, Value = 143.1129183},
                    new YearDetail {Year = 2017, Value = 146.3846292},
                    new YearDetail {Year = 2018, Value = 151.8938749},
                    new YearDetail {Year = 2019, Value = 156.0052634},
                    new YearDetail {Year = 2020, Value = 146.6080707},
                    new YearDetail {Year = 2021, Value = 152.7817528},
                    new YearDetail {Year = 2022, Value = 158.8514672},
                    new YearDetail {Year = 2023, Value = 164.53223},
                    new YearDetail {Year = 2024, Value = 168.8152812},
                    new YearDetail {Year = 2025, Value = 170.2342669},

                },
                DataMetricId = 2,

            },
            new MeasureResearchDetail()
            {
                ProjectId = 670,
                CountryCode = "GB",
                ProductId = 7253,
                DataTypeId = 913,
                DatasetId = 458,
                ChannelId = 2378,
                MeasureSubtype = "Citric Acid",
                MeasureBandMin = null,
                MeasureBandMax = null,
                UnitId = null,
                YearDetails =
                {
                    new YearDetail {Year = 2006, Value = 0.27748},
                    new YearDetail {Year = 2007, Value = 0.27748},
                    new YearDetail {Year = 2008, Value = 0.27748},
                    new YearDetail {Year = 2009, Value = 0.27748},
                    new YearDetail {Year = 2010, Value = 0.27748},
                    new YearDetail {Year = 2011, Value = 0.27748},
                    new YearDetail {Year = 2012, Value = 0.27748},
                    new YearDetail {Year = 2013, Value = 0.27748},
                    new YearDetail {Year = 2014, Value = 0.27748},
                    new YearDetail {Year = 2015, Value = 0.27748},
                    new YearDetail {Year = 2016, Value = 0.27748},
                    new YearDetail {Year = 2017, Value = 0.27748},
                    new YearDetail {Year = 2018, Value = 0.28648},
                    new YearDetail {Year = 2019, Value = 0.28648},
                    new YearDetail {Year = 2020, Value = 0.28648},
                    new YearDetail {Year = 2021, Value = 0.28648},
                    new YearDetail {Year = 2022, Value = 0.28648},
                    new YearDetail {Year = 2023, Value = 0.28648},
                    new YearDetail {Year = 2024, Value = 0.28648},
                    new YearDetail {Year = 2025, Value = 0.28648},

                },
                DataMetricId = 1,
            }
        };
        var one = somethings.SelectMany(x => x.YearDetails).GroupBy(y => y.Year).
            Select(z => new YearDetail()
            {
                Year = z.Key,
                Value = z.Sum(w => w.Value)
            });
        //var dd = new List<YearDetail>();
        //foreach (var xx in somethings.SelectMany(x => x.YearDetails))
        //{
        //    var dddd = dd.FirstOrDefault(x => x.Year == xx.Year);
        //    if (dddd is not null)
        //    {
        //        dddd.Value += xx.Value;
        //    }
        //    else
        //    {
        //        dd.Add(xx);
        //    }
        //}
        //var dd = new List<MeasureResearchDetail>();
        //var ddd = somethings.DeepClone();
        //foreach (var tt in somethings)
        //{
        //    dd.Add(tt.Clone());
        //}

        //foreach (var s in somethings)
        //{
        //    foreach (var s1 in s.YearDetails)
        //    {
        //        s1.Value = 100;
        //    }
        //}
    }
    public static double GetActualYearValue(double? measureYearDetailValue, double? sizeYearDetailValue, int? unitMultiplier)
    {
        var yearValue = Convert.ToDouble(measureYearDetailValue * sizeYearDetailValue * unitMultiplier / 100);
        return double.IsInfinity(yearValue) || double.IsNaN(yearValue) ? 0 : yearValue;
    }
}

