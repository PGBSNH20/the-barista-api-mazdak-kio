using System;
using System.Collections.Generic;
using System.Linq;

namespace The_barista
{

    public class Nothing : IBeverage
    {
        public List<string> Ingredients => new List<string>();

        public string Name => "Nothing";


        public int Temp { get; set; } = 0;
        CupType IBeverage.CupType { get; set; } = CupType.Medium;
    }
}