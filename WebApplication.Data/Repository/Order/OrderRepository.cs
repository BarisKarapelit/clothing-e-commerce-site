using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Data.Context;
using WebApplication.Data.Domain;
using WebApplication.Data.Repository.Base;

namespace WebApplication.Data.Repository.Order;

public class OrderRepository : GenericRepository<Domain.Order>, IOrderRepository
{
    public OrderRepository(WebAppDbContext context) : base(context)
    {
    }

}
