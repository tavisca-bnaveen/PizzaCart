using System.Collections.Generic;

namespace PizzaCart
{
    public class PizzaMenu
    {
        private List<Pizza> _pizzas = new List<Pizza>();
        private Dictionary<string, double> _toppingPrices;
        private Dictionary<Size, double> _sizePrices;
        public PizzaMenu()
        {
            
            _sizePrices= new Dictionary<Size, double>()
            {
                
                    { Size.large,1.5},
                    { Size.regular,1},
                    { Size.medium,1.25},
                    { Size.small,0.75}

            };
            
        }
        public void Intialize()
        {
            _pizzas.Add(new Pizza { Name = "butterchickenPizza", Category = Category.NonVeg, IntialPrice = 1000 });
            _pizzas.Add(new Pizza { Name = "PaneerPizza", Category = Category.Veg, IntialPrice = 500 });

            _toppingPrices = new Dictionary<string, double>()
             {
                 {"cheese",100 },
                 {"Tomota",50 },
                 {"mayo",100 },
                 { "onion",200}
             };
        }
        public Dictionary<string, double> GetToppingsPrices()
        {
            return _toppingPrices;
        }
        public List<Pizza> GetPizzas()
        {
            return _pizzas;
        }
        public Dictionary<Size, double> GetSizePrices()
        {
            return _sizePrices;
        }
        public void AddPizzaToMenu(string name,Category category,double price)
        {
            _pizzas.Add(new Pizza { Name = name, Category = category, IntialPrice = price });
        }
        public void AddToppings(string name,double price)
        {
            _toppingPrices[name] = price;
        }

    }
}
