﻿using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace The_barista
{
    public class Program
    {
        public static void Main()
        {
            IBeverage espresso = new FluentEspresso()
                .AddHotWater(20)
                .AddGrindedBeans()
                .AddCoffeeBeans(new Beans(4, "Arabica"))
                .AddMilk()
                .ToBeverage();

            IBeverage cappuccino = new FluentEspresso()
                .AddCoffeeBeans(new Beans(4, "Arabica"))
                .AddMilk()
                .AddFoamMilk()
                .ToBeverage();

            //foreach (var ingredient in espresso.Ingredients)
            //{
            //    Console.WriteLine(ingredient);
            //}
        }
    }

    public interface IBeverage
    {
        List<string> Ingredients { get; }
        string CupType { get; }
        IBeverage AddHotWater(int percent);
        IBeverage AddMilk();
        IBeverage AddFoamMilk();
        IBeverage AddCoffeeBeans(Beans beans);
        IBeverage AddGrindedBeans();
        IBeverage ToBeverage();
    }

    public class FluentEspresso : IBeverage
    {
        public string CupType => " ";

        public List<string> Ingredients { get; }


        public FluentEspresso()
        {
            Ingredients = new List<string>();
        }

        public IBeverage AddCoffeeBeans(Beans beans)
        {
            
            Ingredients.Add("Coffee Beans Added!");

            return this;
        }

        public IBeverage AddFoamMilk()
        {
            Ingredients.Add("Milk Foam Added!");

            return this;
        }

        public IBeverage AddGrindedBeans()
        {
            Ingredients.Add("Grinded Beans Added!");

            return this;
        }

        public IBeverage AddHotWater(int percent)
        {
            Ingredients.Add("Hot Water Added!");

            return this;
        }

        public IBeverage AddMilk()
        {
            Ingredients.Add("Milk Added!");
            
            return this;
        }

        public IBeverage ToBeverage()
        {
            if (Ingredients.Contains("Coffee Beans Added!") &&
                Ingredients.Contains("Milk Added!") &&
                Ingredients.Contains("Milk Foam Added!"))
            {
                Console.WriteLine("Your beverage is Cappuccino");
            }
            else if (Ingredients.Contains("Milk Added!") && Ingredients.Contains("Coffee Beans Added!"))
            {
                Console.WriteLine("Your beverage is Espresso");
            }

            return this;
        }
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

    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void ExampleTest()
        {
            using FakeConsole console = new FakeConsole("First input", "Second input");
            Program.Main();
            Assert.AreEqual("Hello!", console.Output);
        }
    }
}

            
            /* pseudo-code
            Espresso espresso = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 5 && b.Sort = CoffeSorts.Robusta).ToBravage();
            //espresso is type of Espresso

            Latte latte = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 7 && b.Sort = CoffeSorts.Robusta).AddMilk().ToBravage();
            //latte is type of Latte
             */
        }
    }
}
