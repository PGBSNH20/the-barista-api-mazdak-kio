using System;
using System.Collections.Generic;
using System.Linq;

namespace The_barista
{

    public class Cappucino : IBeverage
    {
        public List<string> Ingredients { get; private set; }
        public string Name { get; private set; }

        private string _name = "Cappucino";

        public Cappucino()
        {
            Name = _name;
            Ingredients = new List<string>() { "Milk", "Coffee Beans", "Milk Foam" };
        }


        CupType IBeverage.CupType { get; set; } = CupType.Large;
        public int Temp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}