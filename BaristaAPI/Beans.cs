using System;
using System.Collections.Generic;
using System.Linq;

namespace The_barista
{

    public class Beans
    {
        public int amountInG;
        public CoffeeBean BeanType { get; set; }
        public enum CoffeeBean
        {
            Arabica,
            Robusta
        }
        public Beans(int amountInG, CoffeeBean sort)
        {
            this.amountInG = amountInG;
            this.BeanType = sort;
        }
    }
}