using WebApplication.Data.Context;
using WebApplication.Data.Domain;
using WebApplication.Data.Repository.Base;

namespace WebApplication.Data.Repository;

public class UserRepository : GenericRepository<User>, IUserRepository
{
    public UserRepository(WebAppDbContext context) : base(context)
    {

    }

    public User GetByUsername(string name)
    {
        return dbContext.Set<User>().Where(x => x.UserName == name).FirstOrDefault();
    }
}
