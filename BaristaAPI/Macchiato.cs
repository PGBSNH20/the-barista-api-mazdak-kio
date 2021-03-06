using System.Collections.Generic;

namespace The_barista
{
    public class Macchiato : IBeverage
    {
        public List<string> Ingredients { get; }
        public string Name { get; }
        public int Degree { get; set; } = 80;

        private readonly string _name = "Macchiato";

        public Macchiato()
        {
            Name = _name;
            Ingredients = new List<string>() { "Coffee Beans", "Milk Foam" };
        }

        CupType IBeverage.CupType { get; set; } = CupType.Medium;
    }
}