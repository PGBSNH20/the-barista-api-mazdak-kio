using System.Collections.Generic;

namespace The_barista
{
    public class Mocha : IBeverage
    {
        public List<string> Ingredients { get; }
        public string Name { get; }
        public int Degree { get; set; } = 90;
        private readonly string _name = "Mocha";

        public Mocha()
        {
            Name = _name;
            Ingredients = new List<string>() { "Coffee Beans", "Chocolate Syrup", "Milk", "Milk Foam" };
        }

        CupType IBeverage.CupType { get; set; } = CupType.Medium;
    }
}