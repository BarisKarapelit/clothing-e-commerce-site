using WebApplication.Base;
using WebApplication.Base.Model;

namespace WebApplication.Schema;

public class TokenRequest : BaseRequest
{
    public string UserName { get; set; }
    public string Password { get; set; }
}
