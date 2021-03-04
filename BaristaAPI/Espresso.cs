using System;
using System.Collections.Generic;
using System.Linq;

namespace The_barista
{

    public class Espresso : IBeverage
    {
        public List<string> Ingredients { get; private set; }
        public string Name { get; private set; }

        private string _name = "Espresso";

        public Espresso()
        {
            Name = _name;
            Ingredients = new List<string>() { "Coffee Beans" };
        }

        CupType IBeverage.CupType { get; set; } = CupType.Small;
        public int Temp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}