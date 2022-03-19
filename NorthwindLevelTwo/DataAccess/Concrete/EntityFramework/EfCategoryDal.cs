using DataAccess.Abstract;
using Entities.Concrete;
using Core.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Concrete.EntityFramework.Contexts;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepository<Category, NorthwindContext>, ICategoryDal
    {
       
    }
}
