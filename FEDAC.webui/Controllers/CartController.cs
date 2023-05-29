using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FEDAC.business.Abstract;
using FEDAC.webui.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FEDAC.webui.Controllers
{
    [Authorize]
    public class CartController:Controller
    {
        private ICartService _cartService;
        private UserManager<User> _userManager;
        public CartController(ICartService cartService,UserManager<User> userManager)
        {
            _cartService = cartService;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            var cart = _cartService.GetCartByUserId(_userManager.GetUserId(User));

            
            Console.WriteLine(cart);
            return View();
        }

        [HttpPost]
        public IActionResult AddToCart()
        {
            return View();
        }
    }
}