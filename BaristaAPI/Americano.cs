using System;
using System.Collections.Generic;
using System.Linq;

namespace The_barista
{

    public class Americano : IBeverage
    {
        public List<string> Ingredients { get; private set; }
        public string Name { get; private set; }

        private string _name = "Americano";

        public Americano()
        {
            Name = _name;
            Ingredients = new List<string>() { "Water", "Coffee Beans" };
        }

        CupType IBeverage.CupType { get; set; } = CupType.Small;
        public int Temp { get; set; } = 85;
    }
}