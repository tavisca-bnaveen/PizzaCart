namespace PizzaCart
{
    public class Order
    {
        private ShoppingCart _shoppingCart;
        public Order(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }
        public string Place()
        {
            var cart = _shoppingCart.GetCart();
            string display = "";
            if (cart.Count > 0)
            {
                display += "Your order is placed with ";
                foreach (var item in _shoppingCart.GetCart())
                {
                    display += item.Name + ",";
                }
                display += "Total price is " + _shoppingCart.GetTotalPriceOfCart();
                
            }
            else
            {
                display += "Your cart is empty";
            }
            return display;

        }
    }
}
