using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FEDAC.data.Abstract;
using FEDAC.entity;
using Microsoft.EntityFrameworkCore;

namespace FEDAC.data.Concrete.EfCore
{
    public class EfCoreCartRepository : EfCoreGenericRepository<Cart, ShopContext>, ICartRepository
    {
        public Cart GetByUserId(string userId)
        {
            using(var context=new ShopContext())
            {
                return context.Carts.Include(i=>i.Cart_items).ThenInclude(i=>i.Product).FirstOrDefault(i=>i.UserId==userId);
                                
                                
                                
            }
        }
    }
}