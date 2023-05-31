using WebApplication.Data.Context;
using WebApplication.Data.Domain;
using WebApplication.Data.Repository.Base;

namespace WebApplication.Data.Repository;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(WebAppDbContext context) : base(context)
    {

    }

    public IEnumerable<Category> FindByName(string name)
    {
        var list = dbContext.Set<Category>().Where(c => c.Name.Contains(name)).ToList();
        return list;
    }

    public int GetAllCount()
    {
        return dbContext.Set<Category>().Count();
    }
}
