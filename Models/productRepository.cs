using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace depenDencyInjectionWIthAutoFac.Models
{
    public class ProductRepository : BaseRepostiroy<Product>
    {
        public ProductRepository(DbContext databaseContext) : base(databaseContext)
        {
        }
    }
}