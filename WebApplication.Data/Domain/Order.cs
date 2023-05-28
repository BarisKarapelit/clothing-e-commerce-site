using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Base.Model;

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
