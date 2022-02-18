namespace BenchMarkLearning
{
    public class CountryProject : IEquatable<CountryProject>
    {
        public int ProjectId { get; set; }
        public string? CountryCode { get; set; }
        public string ParentCountryCode { get; set; }
        public byte CountryLevel { get; set; }
        public short CountryTypeId { get; set; }
        public bool IsNotToBeGrouped { get; set; }
        public short DatasetId { get; set; }

        public bool Equals(CountryProject other)
        {
            if (other is null)
            {
                return false;
            }

            return DatasetId == other.DatasetId &&
                   ProjectId == other.ProjectId &&
                   CountryCode == other.CountryCode &&
                   ParentCountryCode == other.ParentCountryCode;
        }

        public override int GetHashCode()
        {
            var hash = new HashCode();
            hash.Add(DatasetId);
            hash.Add(ProjectId);
            hash.Add(CountryCode);
            hash.Add(ParentCountryCode);
            return hash.ToHashCode();
        }
    }
}
