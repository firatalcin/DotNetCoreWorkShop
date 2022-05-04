using Directory.BLL.Repository.Abstract;
using Directory.DAL.Context;
using Directory.MODEL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Directory.BLL.Repository.Concrete
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        public void Add(T entity)
        {
            using (MyDbContext context = new MyDbContext())
            {
                entity.Status = MODEL.Enums.DataStatus.Inserted;
                entity.CreatedDate = DateTime.Now;
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (MyDbContext context = new MyDbContext())
            {
                entity.Status = MODEL.Enums.DataStatus.Deleted;
                entity.ModifiedDate = DateTime.Now;
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            using (MyDbContext context = new MyDbContext())
            {
                return context.Set<T>().Where(filter).SingleOrDefault();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (MyDbContext context = new MyDbContext())
            {
                return filter == null ? context.Set<T>().ToList() : context.Set<T>().Where(filter).ToList();
            }
        }

        public T GetByID(int id)
        {
            using(MyDbContext context = new MyDbContext())
            {
                return context.Set<T>().FirstOrDefault(x => x.Id == id);
            }
        }

        public void Update(T entity)
        {
            using (MyDbContext context = new MyDbContext())
            {
                entity.Status = MODEL.Enums.DataStatus.Updated;
                entity.ModifiedDate = DateTime.Now;
                context.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
