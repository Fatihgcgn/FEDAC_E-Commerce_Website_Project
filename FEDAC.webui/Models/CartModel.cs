using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FEDAC.webui.Models
{
    public class CartModel
    {
        public int CartId { get; set; }
        public List<CartItemModel> Cart_items { get; set; }
    }

    public class CartItemModel
    {
        public int CartItemId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string ImageUrl { get; set; }
        public int Quantity { get; set; }



    }
}