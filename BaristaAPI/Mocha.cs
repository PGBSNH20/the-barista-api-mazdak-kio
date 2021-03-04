using System;
using System.Collections.Generic;
using System.Linq;

namespace The_barista
{

    public class Mocha : IBeverage
    {
        public List<string> Ingredients { get; private set; }
        public string Name { get; private set; }
        private string _name = "Mocha";

        public Mocha()
        {
            Name = _name;
            Ingredients = new List<string>() { "Coffee Beans", "Chocolate Syrup", "Milk", "Milk Foam" };
        }

        CupType IBeverage.CupType { get; set; } = CupType.Medium;
        public int Temp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}