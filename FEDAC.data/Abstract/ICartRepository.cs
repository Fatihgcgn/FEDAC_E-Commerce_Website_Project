using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FEDAC.entity;

namespace FEDAC.data.Abstract
{
    public interface ICartRepository: IRepository<Cart>
    {
        Cart GetByUserId(string userId);
    }
}