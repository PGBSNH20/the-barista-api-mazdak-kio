using The_barista;
using Xunit;

namespace BaristaApi.Tests
{
    public class FluentApiTests 
    {
        [Fact]
        public void When_AddingWaterAndBeansAndMilkFoam_Expect_Macchiato(){

            // Act
            IBeverage macchiato = new FluentEspresso().AddCoffeeBeans(new Beans(4, "Arabica")).AddMilkFoam().ToBeverage();
            // Assert
            Assert.IsType<Macchiato>(macchiato);
        }
        
        [Fact]
        public void When_AddingWaterAndBeansAndMilk_Expect_Latte()
        {

            // Act
            IBeverage latte = new FluentEspresso().AddCoffeeBeans(new Beans(4, "Arabica")).AddMilk().ToBeverage();
            // Assert
            Assert.IsType<Latte>(latte);
        }

        [Fact]
        public void When_AddingWaterAndBeansAndMilkAndMilkFoamAndChocolate_Expect_Mocha()
        {

            // Act
            IBeverage mocha = new FluentEspresso().AddCoffeeBeans(new Beans(4, "Arabica")).AddMilk().AddMilkFoam().AddChocolateSyrup().ToBeverage();
            // Assert
            Assert.IsType<Mocha>(mocha);
        }
    }
}