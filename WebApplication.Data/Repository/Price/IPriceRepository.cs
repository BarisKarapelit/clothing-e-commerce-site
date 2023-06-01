using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Data.Domain;
using WebApplication.Data.Repository.Base;

namespace WebApplication.Data.Repository.Price
{
    public interface IPriceRepository:IGenericRepository<Domain.Price>
    {
    }
}
