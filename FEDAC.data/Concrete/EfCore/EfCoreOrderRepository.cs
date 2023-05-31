using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FEDAC.data.Abstract;
using FEDAC.entity;

namespace FEDAC.data.Concrete.EfCore
{
    public class EfCoreOrderRepository: EfCoreGenericRepository<Order,ShopContext>, IOrderRepository
    {
        
    }
}