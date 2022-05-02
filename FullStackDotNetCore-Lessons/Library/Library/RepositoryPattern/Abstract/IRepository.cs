using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Library.RepositoryPattern.Abstract
{
    public interface IRepository<T> where T: BaseEntity
    {
        List<T> GetAll();
        List<T> GetActives();
        T GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        void HardDelete(int id);
        List<T> GetByFilter(Expression<Func<T,bool>> filter);
        int Count();
        T Default(Expression<Func<T, bool>> filter);
        bool Any(Expression<Func<T,bool>> filter);
        List<T> SelectActivesByLimit(int count);

    }
}
