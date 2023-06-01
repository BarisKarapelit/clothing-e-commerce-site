using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Base.Model;

namespace WebApplication.Schema.Basket
{
    public class BasketResponse:BaseResponse
    {
        public string UserId { get; set; }
        public UserResponse User { get; set; }  
        public double Total { get; set; }
        public bool IsValid { get; set; }
        public bool IsDelivered { get; set; }
        public bool IsPaid { get; set; }
    }
}
