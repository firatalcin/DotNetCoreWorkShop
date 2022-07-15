using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericDal<T> : IGenericDal<T> where T : class
    {
        public void Delete(T entity)
        {
            using ProjectDb context = new();
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public T Get(int id)
        {
            using ProjectDb context = new();
            return context.Set<T>().Find(id);
        }

        public List<T> GetAll()
        {
            using ProjectDb context = new();
            return context.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            using ProjectDb context = new();
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            using ProjectDb context = new();
            context.Set<T>().Update(entity);
            context.SaveChanges();
        }
    }
}