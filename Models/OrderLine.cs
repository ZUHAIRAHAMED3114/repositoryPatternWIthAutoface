using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace depenDencyInjectionWIthAutoFac.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int count { get; set; }
        // this define the foreigh key relation ship 
        public int ProductId { get; set; }
        public Product Product { get; set; }
        // this below aslo define the foreigh key relation ship
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}