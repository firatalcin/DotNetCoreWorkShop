using Library.Context;
using Library.Models;
using Library.RepositoryPattern.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Library.RepositoryPattern.Concrete
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        MyDbContext _db = new MyDbContext();
        protected DbSet<T> table;


        public Repository()
        {
            table = _db.Set<T>();
        }

        private void Save()
        {
            _db.SaveChanges();
        }

        public void Add(T entity)
        {
            table.Add(entity);
            Save();
        }

        public bool Any(Expression<Func<T, bool>> filter)
        {
            return table.Any(filter);
        }

        public int Count()
        {
           return table.Count();
        }

        public void Delete(int id)
        {
            T item = GetById(id);
            item.Status = Enums.DataStatus.Delete;
            item.ModifiedDate = DateTime.Now;
            table.Update(item);
            Save();
        }

        public List<T> GetActives()
        {
            return table.Where(x => x.Status != Enums.DataStatus.Delete).ToList();
        }

        public List<T> GetAll()
        {
            return table.ToList();
        }

        public List<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
            return table.Where(filter).ToList();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public void HardDelete(int id)
        {
            T item = GetById(id);
            table.Remove(item);
            Save();
        }

        public List<T> SelectActivesByLimit(int count)
        {
            return table.Where(x => x.Status != Enums.DataStatus.Delete).Take(count).ToList();
        }

        public void Update(T entity)
        {
            entity.Status = Enums.DataStatus.Update;
            entity.ModifiedDate = DateTime.Now;
            table.Update(entity);
            Save();
        }

        public T Default(Expression<Func<T, bool>> filter)
        {
           return  table.FirstOrDefault(filter);
        }
    }
}
