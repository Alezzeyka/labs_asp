using System;

namespace ASPLab.Data.Models
{
    public class ShopCartItem
    {
        public Guid ID { get; set; }
        public Dish Dish { get; set; }
        public float Price { get; set; }
        public Guid ShopCartID { get; set; }
    }
}
