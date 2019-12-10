using System;
using Xunit;

namespace PizzaCart.Tests
{
    public class PizzaMenuTests
    {
        [Fact]
        public void Test_For_Intializing_Menu()
        {
            var menu = new PizzaMenu();
            menu.Intialize();
            Assert.Equal(2, menu.GetPizzas().Count);
            
        }
        [Fact]
        public void Test_For_Adding_Pizza_To_Menu()
        {
            var menu = new PizzaMenu();
            menu.AddPizzaToMenu("PanPizza", Category.NonVeg, 1000);
            Assert.Single(menu.GetPizzas());

        }
        [Fact]
        public void Test_For_ToppingPrice_In_Menu()
        {
            var menu = new PizzaMenu();
            menu.Intialize();
            Assert.Equal(100, menu.GetToppingsPrices()["cheese"]);

        }
        [Fact]
        public void Test_For_Size_In_Menu()
        {
            var menu = new PizzaMenu();
            
            Assert.Equal(1.5, menu.GetSizePrices()[Size.large]);
            Assert.Equal(1, menu.GetSizePrices()[Size.regular]);
            Assert.Equal(1.25, menu.GetSizePrices()[Size.medium]);
            Assert.Equal(0.75, menu.GetSizePrices()[Size.small]);

        }
        [Fact]
        public void Test_For_Count_Of_Sizes_In_Menu()
        {
            var menu = new PizzaMenu();
            
            Assert.Equal(4, menu.GetSizePrices().Count);

        }


    }
}
