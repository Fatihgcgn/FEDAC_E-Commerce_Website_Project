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

        public void AddToCart(string userId, int productId, int quantity)
        {
            var cart = GetCartByUserId(userId);

            if(cart!=null)
            {
                var index = cart.Cart_items.FindIndex(i=>i.ProductId==productId);
                if(index<0)
                {
                    cart.Cart_items.Add(new Cart_item(){
                        ProductId = productId,
                        Quantity = quantity,
                        CartId = cart.Id
                    });                    
                }
                else{
                    cart.Cart_items[index].Quantity += quantity;
                }

                _cartRepository.Update(cart);

            }
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