using System.Collections.Generic;

namespace The_barista
{
    public interface IBeverage
    {
        public string Name { get; }
        [Description("The ingredients for the current coffee object")]
        List<string> Ingredients { get; }
        [Description("Sets the coffee cup size")]
        CupType CupType { get; set; }
        [Description("Sets the coffee temperature")]
        public int Degree { get; set; }
    }
}
