using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class CategoryDal : GenericDal<Category>, ICategoryDal
    {
    }
}