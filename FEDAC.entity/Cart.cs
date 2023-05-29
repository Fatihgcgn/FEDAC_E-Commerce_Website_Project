using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FEDAC.entity
{
    public class Cart
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public List<Cart_item> Cart_items { get; set; }
    }
}