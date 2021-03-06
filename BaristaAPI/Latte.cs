using System.Collections.Generic;

namespace The_barista
{
    public class Latte : IBeverage
    {
        public List<string> Ingredients { get; }
        public string Name { get; }
        public int Degree { get; set; } = 60;

        private readonly string name = "Latte";

        public Latte()
        {
            Name = name;
            Ingredients = new List<string>() { "Milk", "Coffee Beans" };
        }

        CupType IBeverage.CupType { get; set; } = CupType.Large;
    }
}