using OrderManagement.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.Entities.Entities
{
    public class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
