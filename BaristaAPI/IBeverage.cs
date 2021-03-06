using System.Collections.Generic;

namespace The_barista
{
    public interface IBeverage
    {
        public string Name { get; }
        List<string> Ingredients { get; }
        CupType CupType { get; set; }
        public int Degree { get; set; }
    }
}