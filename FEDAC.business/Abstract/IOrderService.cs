using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FEDAC.entity;

namespace FEDAC.business.Abstract
{
    public interface IOrderService
    {
        void Create(Order entity);
    }
}