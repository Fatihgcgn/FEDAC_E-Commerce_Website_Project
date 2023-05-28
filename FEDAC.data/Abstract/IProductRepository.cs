using FEDAC.entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FEDAC.data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        Product GetProductDetails(string Url);
        Product GetByIdWithCategories(int id);
        List<Product> GetProductsByCategory(string name, int page, int pageSize);
        List<Product> GetSearchResult(string searchString);
        List<Product> GetHomePageProducts();
        int GetCountByCategory(string category);
        void Update(Product entity, int[] categoryIds);

    }
}