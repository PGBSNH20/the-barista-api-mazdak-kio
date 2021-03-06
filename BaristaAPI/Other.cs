using System.Collections.Generic;

namespace The_barista
{
    public class Other : IBeverage
    {
        public List<string> Ingredients => null;

        public string Name => "Other";
        public int Degree { get; set; } = 0;

        CupType IBeverage.CupType { get; set; } = CupType.Medium;
    }
}