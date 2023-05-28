using WebApplication.Base.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication.Base;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication.Base.Model;
using WebApplication.Data.Domain;

namespace WebApplication.Data.Domain;

public class Order : BaseModel
{
    public int BasketId { get; set; }
    public int UserID { get; set; }
    public int ProductId { get; set; }
    public int Amount { get; set; }
    public bool IsValid { get; set; }

    public virtual Basket Basket { get; set; }
    public virtual User User { get; set; }
    public virtual Product Product { get; set; }


}
