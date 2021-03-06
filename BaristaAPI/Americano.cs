using System.Collections.Generic;

namespace The_barista
{
    public class Americano : IBeverage
    {
        public List<string> Ingredients { get; }
        public int Degree { get; set; } = 90;
        public string Name { get; }

        private readonly string _name = "Americano";

        public Americano()
        {
            Name = _name;
            Ingredients = new List<string>() { "Water", "Coffee Beans" };
        }

        CupType IBeverage.CupType { get; set; } = CupType.Small;
    }
}