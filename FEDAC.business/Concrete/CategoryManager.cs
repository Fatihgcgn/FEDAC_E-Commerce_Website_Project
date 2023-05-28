using System.Collections.Generic;
using FEDAC.business.Abstract;
using FEDAC.data.Abstract;
using FEDAC.entity;

namespace FEDAC.business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        public CategoryManager(ICategoryRepository categoryRepository)
        {
            _categoryRepository=categoryRepository;
        }

        public string ErrorMessage { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void Create(Category entity)
        {
            _categoryRepository.Create(entity);
        }

        public void Delete(Category entity)
        {
            _categoryRepository.Delete(entity);
        }

        public void DeleteFromCategory(int productId, int categoryId)
        {
            _categoryRepository.DeleteFromCategory(productId,categoryId);
        }

        public List<Category> GetAll()
        {
            return _categoryRepository.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public Category GetByIdWithProducts(int categoryid)
        {
            return _categoryRepository.GetByIdWithProducts(categoryid);
        }

        public void Update(Category entity)
        {
            _categoryRepository.Update(entity);
        }

        public bool Validation(Category entity)
        {
            throw new System.NotImplementedException();
        }
    }
}