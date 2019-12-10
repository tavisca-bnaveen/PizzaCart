using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCart
{
    public class ShoppingCart
    {
        private Dictionary<string, double> _toppingPrices;
        private Dictionary<Size, double> _sizePrices;
        private List<Pizza> _pizzas = new List<Pizza>();
        private List<Pizza> _selectedPizzas = new List<Pizza>();
        public ShoppingCart(List<Pizza>  pizzas, Dictionary<string, double> toppingPrices, Dictionary<Size, double> sizePrices)
        {
            _pizzas = pizzas;
            _toppingPrices = toppingPrices;
            _sizePrices = sizePrices;
            
        }


        public void AddPizza(string pizzaName, List<string> toppings, string size)
        {
            var pizza = _pizzas.FirstOrDefault(p => p.Name == pizzaName);
            if(pizza!=null)
            {
                try
                {
                    pizza.Size = (Size)Enum.Parse(typeof(Size), size.ToLower());
                }
                catch
                {
                    pizza.Size = Size.regular;
                }
            }
            if (pizza != null && toppings!=null)
            {
                pizza.FinalPrice = pizza.IntialPrice;
                foreach (var item in toppings)
                {
                    
                    if (_toppingPrices.ContainsKey(item))
                        pizza.FinalPrice += _toppingPrices[item];
                }
                pizza.FinalPrice *= _sizePrices[pizza.Size];
                pizza.SelectedToppings = toppings;
                _selectedPizzas.Add(pizza);
            }
           else if (pizza != null && toppings == null)
            {
                pizza.FinalPrice = pizza.IntialPrice;
                pizza.FinalPrice *= _sizePrices[pizza.Size];
                
                _selectedPizzas.Add(pizza);
            }
            
            
        }
        public bool RemovePizza(string pizzaName)
        {
            var SelectedPizza = _selectedPizzas.FirstOrDefault(p => p.Name==pizzaName);
            if (SelectedPizza != null)
            {
                _selectedPizzas.Remove(SelectedPizza);
                return true;
            }
            return false;
        }
        public List<Pizza> GetCart()
        {
            return _selectedPizzas;
        }
        public double GetTotalPriceOfCart()
        {
             double _totalPrice = 0;
            foreach (var item in _selectedPizzas)
            {
                _totalPrice += item.FinalPrice;
            }
            return _totalPrice;
        }
    }
}
