using Microsoft.EntityFrameworkCore;
using FEDAC.data.Abstract;
using System.Linq;
using System.Collections.Generic;

namespace FEDAC.data.Concrete.EfCore
{
    public class EfCoreGenericRepository<T_Entity, T_Context> : IRepository<T_Entity>

        where T_Entity : class
        where T_Context : DbContext, new()  //newle'nebilir instance olması için yaptık.
    {
        public void Create(T_Entity entity)
        {
            using(var context = new T_Context())
            {
                context.Set<T_Entity>().Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T_Entity entity)
        {
            using(var context = new T_Context())
            {
                context.Set<T_Entity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<T_Entity> GetAll()
        {
            using(var context = new T_Context())
            {
                return context.Set<T_Entity>().ToList();
            }
        }

        public T_Entity GetById(int id)
        {
            using(var context = new T_Context())
            {
                return context.Set<T_Entity>().Find(id);
            }
        }

        public void Update(T_Entity entity)
        {
            using(var context = new T_Context())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}