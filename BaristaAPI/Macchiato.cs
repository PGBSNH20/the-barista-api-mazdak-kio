using System.Collections.Generic;

namespace The_barista
{
    public class Macchiato : IBeverage
    {
        public List<string> Ingredients { get; private set; }
        public string Name { get; private set; }

        private string _name = "Macchiato";


        public Macchiato()
        {
            Name = _name;
            Ingredients = new List<string>() { "Coffee Beans", "Milk Foam" };
        }

        CupType IBeverage.CupType { get; set; } = CupType.Medium;
        public int Temp { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}