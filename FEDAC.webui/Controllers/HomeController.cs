using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//controller kalıtım için eklediğimiz kütüphane.
using Microsoft.AspNetCore.Mvc;
using FEDAC.data.Abstract;
using FEDAC.business.Abstract;
using FEDAC.webui.Models;

namespace FEDAC.webui.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productService;
        public HomeController(IProductService productService)
        {
            this._productService=productService;
        }

        public IActionResult Index()
        {
            var productViewModel = new ProductListViewModel(){
                Products = _productService.GetHomePageProducts()
            };

            return View(productViewModel);
        }

        //localhost:5001/home/about
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View("MyContact");
        }
    }
}