
using WebApplication.Base.Response;
using WebApplication.Schema;

namespace WebApplication.Operation;

public interface ITokenService
{
    ApiResponse<TokenResponse> GetToken(TokenRequest request);
}
