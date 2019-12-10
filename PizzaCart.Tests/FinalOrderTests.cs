using System.Collections.Generic;
using Xunit;

namespace PizzaCart.Tests
{
    public class FinalOrderTests
    {
        [Fact]
        public void Test_For_Placing_Order()
        {
            var pizzaMenu = new PizzaMenu();
            pizzaMenu.Intialize();
            var cart = new ShoppingCart(pizzaMenu.GetPizzas(), pizzaMenu.GetToppingsPrices(), pizzaMenu.GetSizePrices());

            cart.AddPizza("butterchickenPizza", new List<string>() { "cheese" }, "large");
            cart.AddPizza("PaneerPizza", new List<string>() { "cheese", "mayo" }, "medium");
            Order order = new Order(cart);
            Assert.Equal("Your order is placed with butterchickenPizza,PaneerPizza,Total price is 2525", order.Place());
        }
        [Fact]
        public void Test_For_Placing_Order_With_Empty_Cart()
        {
            var pizzaMenu = new PizzaMenu();
            pizzaMenu.Intialize();
            var cart = new ShoppingCart(pizzaMenu.GetPizzas(), pizzaMenu.GetToppingsPrices(), pizzaMenu.GetSizePrices());

            
            Order order = new Order(cart);
            Assert.Equal("Your cart is empty", order.Place());
        }
    }
}
