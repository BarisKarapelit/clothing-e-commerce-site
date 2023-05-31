using WebApplication.Base.Model;

namespace WebApplication.Schema;

public class CategoryRequest : BaseRequest
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Order { get; set; }
}
