using FEDAC.data.Abstract;
using FEDAC.entity;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FEDAC.data.Concrete.SQL
{
    public class SQLCategoryRepository : ICategoryRepository
    {
        public void Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteFromCategory(int productId, int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetByIdWithProducts(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetPopularCategories()
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}