using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace depenDencyInjectionWIthAutoFac.Models
{
    public class orderLineRepository : BaseRepostiroy<OrderLine>
    {
        public orderLineRepository(DbContext databaseContext) : base(databaseContext)
        {
        }
    }
}