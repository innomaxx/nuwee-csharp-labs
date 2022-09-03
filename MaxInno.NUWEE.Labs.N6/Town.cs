
namespace MaxInno.NUWEE.Labs.N6
{
    public class Town
    {
        public string Name { get; set; }

        public string Country { get; set; }

        public string Region { get; set; }

        public int Population { get; set; }

        public double YearIncome { get; set; }

        public double Square { get; set; }

        public bool HasPort { get; set; }

        public bool HasAirport { get; set; }
        
        public bool HasBikeRoads { get; set; }

        public double GetYearIncomePerInhabitant() => YearIncome / Population;
    }
}
