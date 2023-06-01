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
    public class OrderRequest:BaseRequest
    {
        public int Id { get; set; }
        public int BasketId { get; set; }
        public BasketRequest Basket { get; set; }
        public int UserID { get; set; }
        public UserRequest User { get; set; }
        public int ProductId { get; set; }
        public ProductRequest Product { get; set; }
        public int Amount { get; set; }
    }
}
