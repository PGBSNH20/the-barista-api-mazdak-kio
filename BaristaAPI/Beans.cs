namespace The_barista
{
    public class Beans
    {
        private readonly int amountInG;
        public BeanType Sort { get; set; }

        public enum BeanType
        {
            Robusta,
            Arabica
        }

        public Beans(int amountInG, BeanType sort)
        {
            this.amountInG = amountInG;
            this.Sort = sort;
        }
    }
}