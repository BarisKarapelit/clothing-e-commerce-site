using WebApplication.Data.Context;
using WebApplication.Data.Domain;
using WebApplication.Data.Repository.Base;

namespace WebApplication.Data.Repository;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(WebAppDbContext context) : base(context)
    {

    }
}
