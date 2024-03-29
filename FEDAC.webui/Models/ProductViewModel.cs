using System;
using System.Collections.Generic;
using FEDAC.entity;

namespace FEDAC.webui.Models
{
    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public string CurrentCategory { get; set; }

        // 10/3=3.3=>4 sayfaları dagitma
        public int TotalPages()
        {
                return (int)Math.Ceiling((decimal)TotalItems/ItemsPerPage);

        }

    }
    public class ProductListViewModel
    {
        public PageInfo PageInfo { get; set; }
        public List<Product> Products { get; set; }
    }
}