using System.Collections.Generic;

namespace The_barista
{
    public class Cappucino : IBeverage
    {
        public List<string> Ingredients { get; }
        public string Name { get; }
        public int Degree { get; set; } = 65;
        private readonly string _name = "Cappucino";

        public Cappucino()
        {
            Name = _name;
            Ingredients = new List<string>() { "Milk", "Coffee Beans", "Milk Foam" };
        }

        CupType IBeverage.CupType { get; set; } = CupType.Large;
    }
}