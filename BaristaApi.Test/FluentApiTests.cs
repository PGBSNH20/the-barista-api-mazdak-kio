using System;
using System.Collections.Generic;
using System.Linq;
using The_barista;
using Xunit;

namespace BaristaApi.Tests
{
    public class FluentApiTests 
    {
        [Fact]
        public void When_AddingWaterAndBeansAndMilkFoam_Expect_Macchiato(){

            // Act
            IBeverage macchiato = new FluentEspresso()
                .AddCoffeeBeans(new Beans(4, "Arabica"))
                .AddMilkFoam()
                .ToBeverage();
            // Assert
            Assert.IsType<Macchiato>(macchiato);
        }
        
        [Fact]
        public void When_AddingWaterAndBeansAndMilk_Expect_Latte()
        {

            // Act
            IBeverage latte = new FluentEspresso()
                .AddCoffeeBeans(new Beans(4, "Arabica"))
                .AddMilk()
                .ToBeverage();
            // Assert
            Assert.IsType<Latte>(latte);
        }

        [Fact]
        public void When_AddingWaterAndBeansAndMilkAndMilkFoamAndChocolate_Expect_Mocha()
        {

            // Act
            IBeverage mocha = new FluentEspresso()
                .AddCoffeeBeans(new Beans(4, "Arabica"))
                .AddMilk()
                .AddMilkFoam()
                .AddChocolateSyrup()
                .ToBeverage();
            // Assert
            Assert.IsType<Mocha>(mocha);
        }

        //[Fact]
        //public void TestingSomething()
        //{
        //    FluentEspresso fluentEspresso = new FluentEspresso();
        //    IBeverage americano = new Americano();
        //    List<string> Ingredients = new List<string>();

        //    IBeverage desiredDrink = americano;
        //    // Act
        //    var drinks = new List<IBeverage>()
        //    {
        //        new Americano(),
        //        new Latte(),
        //        new Cappucino(),
        //        new Macchiato(),
        //        new Mocha(),
        //        new Espresso()
        //    };

        //    if(fluentEspresso.Ingredients == americano.Ingredients)
        //    {

        //    }
        //    else
        //    {
        //        // Assert
        //        Assert.ThrowsAny<Exception>(() => desiredDrink.ToBeverage());
        //    }
        //}
    }
}