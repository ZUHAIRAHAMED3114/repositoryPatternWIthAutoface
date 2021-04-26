using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace depenDencyInjectionWIthAutoFac.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public decimal totalCost { get; set; }
        public ICollection<OrderLine> Lines {get;set;}

            
     }
}