using WebApplication.Data;
using WebApplication.Data.Domain;
using WebApplication.Operation.WebApplication.Operation.Base;
using WebApplication.Schema;

namespace WebApplication.Operation;

public interface IUserService : IBaseService<User,UserRequest,UserResponse>
{

}
