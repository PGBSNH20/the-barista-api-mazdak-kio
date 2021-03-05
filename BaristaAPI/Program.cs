using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

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
            //Func<IBeverage, bool> result = r => r.Degree > 80;
            //Console.WriteLine(result(new Mocha()));

            //IFluentEspresso cappuccino = new FluentEspresso()
            //    .AddCoffeeBeans(new Beans(4, "Arabica"))
            //    .AddMilk()
            //    .AddMilkFoam();


            IBeverage macchiato = new FluentEspresso()
                .AddCoffeeBeans(new Beans(4, "Arabica"))
                .AddMilk()
                .AddChocolateSyrup()
                .ToBeverage();

            Console.WriteLine();
        }
    }

    public interface IBeverage
    {
        public string Name { get; }
        List<string> Ingredients { get; }
        CupType CupType { get; set; }
        public int Degree { get; set; }

    }

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

    // Lägg till conditions så att kaffe måste väljas för att kunna få en dryck.

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

            if (deg)
            {
                Console.WriteLine("Perfect temperature. Enjoy your " + this.ToBeverage().Name + "!");
                return this;
            }
            else if (!deg)
            {
                Console.WriteLine("Too cold, need to be warmer");
                Thread.Sleep(3000);
                Console.WriteLine("Now your " + this.ToBeverage().Name + " is at least " + this.ToBeverage().Degree + " degree Celsius, Enjoy!");
                return this;
            }
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
                new Espresso()
            };

            // Ser till så att drinkens lista med ingredienser matchar med de angivna listans ingredienser.
            var desiredDrink = drinks.FirstOrDefault(d => Enumerable.SequenceEqual(d.Ingredients.OrderBy(i => i), this.Ingredients.OrderBy(i => i)));

            // Om inte ingredienserna matchar 
            if (desiredDrink == null)
            {
                return new Other();
            }

            // Tänk ifall drinken är null eller har andra ingredienser som vi inte har en klass av som ex. Espresso, Latte, ...? 
            return desiredDrink;
        }

        
    }

    public class Americano : IBeverage
    {
        public List<string> Ingredients { get; private set; }
        public int Degree { get; set; } = 90;
        public string Name { get; private set; }

        private string _name = "Americano";

        public Americano()
        {
            Name = _name;
            Ingredients = new List<string>() { "Water", "Coffee Beans" };
        }

        CupType IBeverage.CupType { get; set; } = CupType.Small;
    }


    public class Latte : IBeverage
    {
        public List<string> Ingredients { get; private set; }
        public string Name { get; private set; }
        public int Degree { get; set; } = 80;

        private string _name = "Latte";

        public Latte()
        {
            Name = _name;
            Ingredients = new List<string>() { "Milk", "Coffee Beans" };
        }

        CupType IBeverage.CupType { get; set; } = CupType.Large;
        
    }

    public class Cappucino : IBeverage
    {
        public List<string> Ingredients { get; private set; }
        public string Name { get; private set; }
        public int Degree { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        private string _name = "Cappucino";

        public Cappucino()
        {
            Name = _name;
            Ingredients = new List<string>() { "Milk", "Coffee Beans", "Milk Foam" };
        }


        CupType IBeverage.CupType { get; set; } = CupType.Large;
    }


    public class Macchiato : IBeverage
    {
        public List<string> Ingredients { get; private set; }
        public string Name { get; private set; }
        public int Degree { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private string _name = "Macchiato";


        public Macchiato()
        {
            Name = _name;
            Ingredients = new List<string>() { "Coffee Beans", "Milk Foam" };
        }

        CupType IBeverage.CupType { get; set; } = CupType.Medium;
    }

    public class Mocha : IBeverage
    {
        public List<string> Ingredients { get; private set; }
        public string Name { get; private set; }
        public int Degree { get; set; } = 90;
        private string _name = "Mocha";

        public Mocha()
        {
            Name = _name;
            Ingredients = new List<string>() { "Coffee Beans", "Chocolate Syrup", "Milk", "Milk Foam" };
        }

        CupType IBeverage.CupType { get; set; } = CupType.Medium;
    }

    public class Espresso : IBeverage
    {
        public List<string> Ingredients { get; private set; }
        public string Name { get; private set; }
        public int Degree { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        private string _name = "Espresso";

        public Espresso()
        {
            Name = _name;
            Ingredients = new List<string>() { "Coffee Beans" };
        }

        CupType IBeverage.CupType { get; set; } = CupType.Small;
    }


    public class Other : IBeverage
    {
        public List<string> Ingredients => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();
        public int Degree { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        CupType IBeverage.CupType { get; set; } = CupType.Medium;
    }

    public class Beans
    {
        public int _amountInG;
        public string _sort;
        public Beans(int amountInG, string sort)
        {
            this._amountInG = amountInG;
            this._sort = sort;
        }
    }
}