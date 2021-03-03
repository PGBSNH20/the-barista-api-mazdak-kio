using The_barista;
using Xunit;

namespace BaristaApi.Tests
{
    public class FluentApiTests 
    {
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Espresso(){
            //Pseudo code

            // Act
            IBeverage macchiato = new FluentEspresso()
                .AddCoffeeBeans(new Beans(4, "Arabica"))
                .AddMilkFoam()
                .ToBeverage();
            // Assert
            Assert.IsType<Macchiato>(macchiato);
        }
    }
}