using WebApplication.Base;
using WebApplication.Base.Model;

namespace WebApplication.Schema;

public class TokenResponse : BaseResponse
{
    public DateTime ExpireTime { get; set; }
    public string AccessToken { get; set; }
    public string UserName { get; set; }
}
