using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace The_barista
{
    public class FluentEspresso : IFluentEspresso
    {
        public List<string> Ingredients { get; }

        public FluentEspresso()
        {
            Ingredients = new List<string>();
        }

        public IFluentEspresso AddCoffeeBeans(Beans beans)
        {
            Ingredients.Add("Coffee Beans");

            return this;
        }

        public IFluentEspresso AddMilkFoam()
        {
            Ingredients.Add("Milk Foam");

            return this;
        }

        public IFluentEspresso AddGrindedBeans()
        {
            Ingredients.Add("Grinded Beans");

            return this;
        }

        public IFluentEspresso AddHotWater(int percent)
        {
            Ingredients.Add("Water");

            return this;
        }

        public IFluentEspresso AddMilk()
        {
            Ingredients.Add("Milk");

            return this;
        }

        public IFluentEspresso AddChocolateSyrup()
        {
            Ingredients.Add("Chocolate Syrup");

            return this;
        }

        public IFluentEspresso AddTemp(Func<IBeverage, bool> degree)
        {
            // deg är där den ska retunera ifall LINQ-satsen stämmer eller ej
            bool deg = degree(ToBeverage());

            switch (deg)
            {
                case true:
                    Console.WriteLine("Perfect temperature. Enjoy your " + this.ToBeverage().Name + "!");
                    return this;

                case false:
                    Console.WriteLine("Too cold, need to be warmer");
                    Thread.Sleep(3000);
                    Console.WriteLine("Now your " + this.ToBeverage().Name + " is at least " + this.ToBeverage().Degree + " degree Celsius, Enjoy!");
                    return this;
            }
        }

        public IBeverage ToBeverage()
        {
            var drinks = new List<IBeverage>()
            {
                new Americano(),
                new Latte(),
                new Cappucino(),
                new Macchiato(),
                new Mocha(),
                new Espresso()
            };

            // Ser till så att drinkens lista med ingredienser matchar med de angivna listans ingredienser.
            var desiredDrink = drinks.FirstOrDefault(d => Enumerable.SequenceEqual(d.Ingredients.OrderBy(i => i), Ingredients.OrderBy(i => i)));

            // Om inte ingredienserna matchar
            return desiredDrink ?? new Other();

            // Tänk ifall drinken är null eller har andra ingredienser som vi inte har en klass av som ex. Espresso, Latte, ...?
        }
    }
}