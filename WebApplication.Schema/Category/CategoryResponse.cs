using WebApplication.Base;
using WebApplication.Base.Model;

namespace WebApplication.Schema;

public class CategoryResponse : BaseResponse
{
    public string Name { get; set; }
    public int Order { get; set; }
    public bool IsValid { get; set; }

}
