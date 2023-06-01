using WebApplication.Data.Domain;
using WebApplication.Data.Repository.Base;

namespace WebApplication.Data.Repository;

public interface IProductRepository : IGenericRepository<Product>
{
    IEnumerable<Product> GetByUsername(string name);

}
