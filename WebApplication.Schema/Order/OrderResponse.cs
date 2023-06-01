using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Base.Model;
using WebApplication.Schema.Basket;
using WebApplication.Schema.Product;

namespace WebApplication.Schema.Order
{
    public class OrderResponse : BaseResponse
    {
        public int BasketId { get; set; }
        public BasketResponse Basket { get; set; }
        public int UserID { get; set; }
        public UserResponse User { get; set; }
        public int ProductId { get; set; }
        public ProductResponse Product { get; set; }
        public int Amount { get; set; }
        public bool IsValid { get; set; }
    }
}
