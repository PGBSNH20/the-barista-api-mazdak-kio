using System.Collections.Generic;

namespace The_barista
{
    public class Espresso : IBeverage
    {
        public List<string> Ingredients { get; }
        public string Name { get; }
        public int Degree { get; set; } = 90;

        private readonly string _name = "Espresso";

        public Espresso()
        {
            Name = _name;
            Ingredients = new List<string>() { "Coffee Beans" };
        }

        CupType IBeverage.CupType { get; set; } = CupType.Small;
    }
}