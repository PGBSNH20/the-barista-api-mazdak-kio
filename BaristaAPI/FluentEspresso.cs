using System;
using System.Collections.Generic;
using System.Linq;

namespace The_barista
{

    public class FluentEspresso : IFluentEspresso
    {
        public List<string> Ingredients { get; }

        public int Temp { get; set; }

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
        public IFluentEspresso SetTemperature(int temp) // Todo Make lambda func "Func<Ibeverage, int> temp"
        {
            Temp = temp;
            return this;
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
                new Espresso(),
                new Other(),
                new Nothing()
            };

            // Ser till så att drinkens lista med ingredienser matchar med de angivna listans ingredienser.
            var desiredDrink = drinks.FirstOrDefault(d => Enumerable.SequenceEqual(d.Ingredients.OrderBy(i => i), Ingredients.OrderBy(i => i)));

            Console.WriteLine(Temp != desiredDrink.Temp
                ? $"{desiredDrink.Name} was brewed but the temperature was wrong\nExpected temp: {desiredDrink.Temp}\nActual Temp: {Temp}"
                : (desiredDrink.Name == "Other") ? $"{desiredDrink.Name} was brewed." : "Nothing was made");

            // Tänk ifall drinken är null eller har andra ingredienser som vi inte har en klass av som ex. Espresso, Latte, ...? 
            return desiredDrink;
        }

        
    }
}