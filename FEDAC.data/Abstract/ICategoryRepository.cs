using FEDAC.entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FEDAC.data.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetByIdWithProducts(int categoryId);
        void DeleteFromCategory(int productId,int categoryId);
    }
}