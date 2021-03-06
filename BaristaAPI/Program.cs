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
            IBeverage macchiato = new FluentEspresso()
                .AddCoffeeBeans(new Beans(4, Beans.BeanType.Arabica))
                .AddMilk()
                .AddChocolateSyrup()
                .AddTemp(d => d.Degree < 80)
                .ToBeverage();
        }
    }
}