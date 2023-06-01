using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Data.Context;
using WebApplication.Data.Repository.Base;

namespace WebApplication.Data.Repository.Price
{
    public class PriceRepository:GenericRepository<Domain.Price>,IPriceRepository
    {
        public PriceRepository(WebAppDbContext context) : base(context) 
        {
        
        }

    }
}
