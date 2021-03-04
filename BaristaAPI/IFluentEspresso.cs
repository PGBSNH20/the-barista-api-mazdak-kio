using System;
using System.Collections.Generic;
using System.Linq;

namespace The_barista
{

    public interface IFluentEspresso
    {
        IFluentEspresso AddHotWater(int percent);
        IFluentEspresso AddMilk();
        IFluentEspresso AddMilkFoam();
        IFluentEspresso AddCoffeeBeans(Beans beans);
        IFluentEspresso AddGrindedBeans();
        IFluentEspresso AddChocolateSyrup();
        IFluentEspresso SetTemperature(int temp);
        IBeverage ToBeverage();

    }
}