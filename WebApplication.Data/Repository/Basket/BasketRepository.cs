using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Data.Context;
using WebApplication.Data.Domain;
using WebApplication.Data.Repository.Base;

namespace WebApplication.Data.Repository.Basket;

public class BasketRepository : GenericRepository<Domain.Basket>
{
    public BasketRepository(WebAppDbContext context) : base(context)
    {
    }
}
