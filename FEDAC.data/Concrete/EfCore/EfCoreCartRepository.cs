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
        public void DeleteFromCart(int CartId, int productId)
        {
            using(var context = new ShopContext())
            {
                var cmd = @"delete from Cart_items where CartId=@p0 and ProductId=@p1";
                context.Database.ExecuteSqlRaw(cmd,CartId,productId);
            }
        }

        public Cart GetByUserId(string userId)
        {
            using(var context=new ShopContext())
            {
                return context.Carts
                    .Include(i=>i.Cart_items)
                    .ThenInclude(i=>i.Product)
                    .FirstOrDefault(i=>i.UserId==userId);                               
            }
        }

        public override void Update(Cart entity) //virtual ile overwrite edebiliyoruz.
        {
            using(var context = new ShopContext())
            {                
                context.Carts.Update(entity);
                context.SaveChanges();
            }
        }
    }
}