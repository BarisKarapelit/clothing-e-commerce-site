using WebApplication.Data.Domain;
using WebApplication.Data.Repository.Base;

namespace WebApplication.Data.Repository;

public interface IUserRepository : IGenericRepository<User>
{
    User GetByUsername(string name);
}
