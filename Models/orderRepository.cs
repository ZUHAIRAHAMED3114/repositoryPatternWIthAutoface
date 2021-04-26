using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace depenDencyInjectionWIthAutoFac.Models
{
    public class orderRepository : BaseRepostiroy<Order>
    {
        public orderRepository(DbContext databaseContext) : base(databaseContext)
        {
        }
    }
}