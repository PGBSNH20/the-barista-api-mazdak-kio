using System;

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

        IFluentEspresso AddTemp(Func<IBeverage, bool> degree);

        IBeverage ToBeverage();
    }
}