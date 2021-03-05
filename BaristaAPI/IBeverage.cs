using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace The_barista
{

    public interface IBeverage
    {
        public string Name { get; }
        List<string> Ingredients { get; }
        CupType CupType { get; set; }

        [Description("Sets the temperature for the coffee object")]
        public int Temp { get; set; }

    }
}