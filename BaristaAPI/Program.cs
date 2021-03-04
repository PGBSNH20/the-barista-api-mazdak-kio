using System;
using System.Collections.Generic;
using System.Linq;

namespace The_barista
{
    // changes
    public enum CupType
    {
        Small,
        Medium,
        Large
    }

    public class Program
    {
        public static void Main()
        {
            //IFluentEspresso espresso = new FluentEspresso()
            //    .AddHotWater(20)
            //    .AddGrindedBeans()
            //    .AddCoffeeBeans(new Beans(4, "Arabica"))
            //    .AddMilk();

            //IFluentEspresso cappuccino = new FluentEspresso()
            //    .AddCoffeeBeans(new Beans(4, "Arabica"))
            //    .AddMilk()
            //    .AddMilkFoam();


            IBeverage cappucino = new FluentEspresso()
                .AddCoffeeBeans(new Beans(4, Beans.CoffeeBean.Arabica))
                .AddMilk()
                .AddMilkFoam()
                .SetTemperature(60)
                .ToBeverage();

            Console.WriteLine();
        }
    }
}