using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FEDAC.business.Abstract;
using FEDAC.data.Abstract;
using FEDAC.entity;

namespace FEDAC.business.Concrete
{
    public class CartManager : ICartService
    {
        private ICartRepository _cartRepository;
        public CartManager(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        public Cart GetCartByUserId(string userId)
        {
            return _cartRepository.GetByUserId(userId);
        }

        public void InitializeCart(string userId)
        {
            _cartRepository.Create(new Cart(){UserId = userId});
        }
    }
}