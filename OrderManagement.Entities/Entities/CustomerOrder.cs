using OrderManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Entities.Entities
{
    public class CustomerOrder : BaseEntity
    {
        public Customer Customer { get; set; }
        public List<Product> Product { get; set; }
    }
}
