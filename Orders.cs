using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignandCode
{
    public class Orders
    {
        public int orderId;
        public DateTime date;
        public List<Product> products;
        public int quantity;
        public float price;

        public float TotalPrice(List<Product> precios)
        {
            float price = List<Product>.Sum();
            return price;
        }
    }

    public class ShoppingCart
    {
        public List<Product> products;
        public Users users;
    }
}
