using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AaronPuffer.DependencyInjection.DTO
{
    public class Order
    {
        public Order()
        {
            Products = new List<OrderedProduct>();
        }

        public string Id { get; set; }

        public string CustomerId { get; set; }

        public List<OrderedProduct> Products { get; set; }

        public decimal SubTotal { get; set; }

        public decimal Tax { get; set; }

        public decimal OrderTotal { get; set; }

        public bool Processed { get; set; }
    }
}
