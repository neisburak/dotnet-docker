using DataAccess.Abstract;
using DataAccess.Data;
using Entities;

namespace DataAccess.Concrete;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(DataContext context) : base(context) { }

}