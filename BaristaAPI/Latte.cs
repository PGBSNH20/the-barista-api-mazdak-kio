using System.Collections.Generic;

namespace The_barista
{
    public class Latte : IBeverage
    {
        public List<string> Ingredients { get; }
        public string Name { get; }

        private readonly string _name = "Latte";

        public Latte()
        {
            Name = _name;
            Ingredients = new List<string>() { "Milk", "Coffee Beans" };
        }

        CupType IBeverage.CupType { get; set; } = CupType.Large;
        public int Temp { get; set; } = 60;
    }
}