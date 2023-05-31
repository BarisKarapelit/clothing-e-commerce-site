using WebApplication.Base;
using WebApplication.Base.Model;
using WebApplication.Data.Domain;
using WebApplication.Data.Repository.Base;

namespace WebApplication.Data.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IGenericRepository<Category> CategoryRepository { get; }
    IGenericRepository<Product> ProductRepository { get; }
    IGenericRepository<User> UserRepository { get; }

    IGenericRepository<Entity> Repository<Entity>() where Entity : BaseModel;

    void Complete();
    void CompleteWithTransaction();
}
