using System.Collections.Generic;
using Xunit;

namespace PizzaCart.Tests
{
    public class ShoppingCartTests
    {
        [Fact]
        public void Test_For_Add_Pizza()
        {
            var pizzaMenu = new PizzaMenu();
            pizzaMenu.Intialize();
            var cart = new ShoppingCart(pizzaMenu.GetPizzas(), pizzaMenu.GetToppingsPrices(), pizzaMenu.GetSizePrices());

            cart.AddPizza("butterchickenPizza", null, "regular");
            Assert.Single(cart.GetCart());
            Assert.Equal(1000, cart.GetTotalPriceOfCart());
        }
        [Fact]
        public void Test_For_Add_Pizza_That_is_Not_Present_In_Cart()
        {
            var pizzaMenu = new PizzaMenu();
            pizzaMenu.Intialize();
            var cart = new ShoppingCart(pizzaMenu.GetPizzas(), pizzaMenu.GetToppingsPrices(), pizzaMenu.GetSizePrices());

            cart.AddPizza("butterchickenPizza1", null, "regular");
            Assert.Empty(cart.GetCart());
            Assert.Equal(0, cart.GetTotalPriceOfCart());
        }
        [Fact]
        public void Test_For_Add_Pizza_With_Toppings()
        {
            var pizzaMenu = new PizzaMenu();
            pizzaMenu.Intialize();
            var cart = new ShoppingCart(pizzaMenu.GetPizzas(), pizzaMenu.GetToppingsPrices(), pizzaMenu.GetSizePrices());

            cart.AddPizza("butterchickenPizza", new List<string>() { "cheese","mayo"}, "regular");
            Assert.Single(cart.GetCart());
            Assert.Equal(1200, cart.GetTotalPriceOfCart());
        }
        [Fact]
        public void Test_For_Add_Multiple_Pizza_With_Toppings()
        {
            var pizzaMenu = new PizzaMenu();
            pizzaMenu.Intialize();
            var cart = new ShoppingCart(pizzaMenu.GetPizzas(), pizzaMenu.GetToppingsPrices(), pizzaMenu.GetSizePrices());

            cart.AddPizza("butterchickenPizza", new List<string>() { "cheese" }, "large");
            cart.AddPizza("PaneerPizza", new List<string>() { "cheese", "mayo" }, "medium");
            Assert.Equal(2,cart.GetCart().Count);
            Assert.Equal(2525, cart.GetTotalPriceOfCart());
        }
        [Fact]
        public void Test_For_Remove_Pizza()
        {
            var pizzaMenu = new PizzaMenu();
            
            var cart = new ShoppingCart(pizzaMenu.GetPizzas(), pizzaMenu.GetToppingsPrices(), pizzaMenu.GetSizePrices());

            cart.AddPizza("butterchickenPizza", null, "regular");
            cart.RemovePizza("butterchickenPizza");
            Assert.Empty(cart.GetCart());
            Assert.Equal(0, cart.GetTotalPriceOfCart());
        }

    }
}
