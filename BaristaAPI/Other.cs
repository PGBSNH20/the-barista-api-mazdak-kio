using System;
using System.Collections.Generic;
using System.Linq;

namespace The_barista
{

    public class Other : IBeverage
    {
        public List<string> Ingredients => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public int Temp { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        CupType IBeverage.CupType { get; set; } = CupType.Medium;
    }
}