using System;
using System.Collections.Generic;

namespace PizzaCart
{
    public class Pizza
    {
        public string Name { get; set; }
        public Size Size { get; set; }
        public Category Category { get; set; }
        public double IntialPrice { get; set; }

        public List<string> SelectedToppings { get; set; }
        
        public double FinalPrice { get; set; }
       

    }    
}
