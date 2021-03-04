using System;
using System.Collections.Generic;
using System.Linq;

namespace The_barista
{

    public class Other : IBeverage
    {
        public List<string> Ingredients => null;

        public string Name => "Other";

        public int Temp { get; set; } = 0;
        CupType IBeverage.CupType { get; set; } = CupType.Medium;
    }
}