using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Base.Model;
using WebApplication.Schema.Product;

namespace WebApplication.Schema.Price;

public class PriceResponse:BaseResponse
{
    public double NetPrice { get; set; }
    public double Discount { get; set; }
    public bool IsValid { get; set; }
    public int ProductId { get; set; }
    public ProductResponse Product { get; set; } 
}
