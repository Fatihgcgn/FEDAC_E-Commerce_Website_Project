using System.Collections.Generic;
using FEDAC.entity;

namespace FEDAC.webui.Models
{
    public class ProductDetailModel
    {
        public Product product { get; set; }
        public List<Category> Categories { get; set; }

    }
}