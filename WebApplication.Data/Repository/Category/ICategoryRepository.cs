using WebApplication.Data.Domain;
using WebApplication.Data.Repository.Base;

namespace WebApplication.Data.Repository;

public interface ICategoryRepository : IGenericRepository<Category>
{
    IEnumerable<Category> FindByName (string name);
    int GetAllCount();
}
