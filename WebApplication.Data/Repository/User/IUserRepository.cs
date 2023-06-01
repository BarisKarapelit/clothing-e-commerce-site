using WebApplication.Data.Domain;
using WebApplication.Data.Repository.Base;

namespace WebApplication.Data.Repository;

public interface IUserRepository : IGenericRepository<User>
{
    IEnumerable<User> GetByUsername(string name);
}
