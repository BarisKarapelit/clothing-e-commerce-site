using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Base.Model;

namespace WebApplication.Schema.Basket
{
    public class BasketRequest : BaseRequest
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public UserRequest User { get; set; }
        public double Total { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsPaid { get; set; }
    }
}
