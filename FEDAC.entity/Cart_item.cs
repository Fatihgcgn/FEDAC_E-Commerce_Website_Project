using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FEDAC.entity
{
    public class Cart_item
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
        public Cart Cart { get; set; }
        public int CartId { get; set; }

        public int Quantity { get; set; }
    }
}