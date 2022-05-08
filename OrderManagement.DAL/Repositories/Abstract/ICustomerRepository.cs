using OrderManagement.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.DAL.Repositories
{
    public interface ICustomerRepository
    {
        Task Create(Customer customer);
        Task<Customer> Get(int id);
        IEnumerable<Customer> GetAllCustomers();
        Customer Update(Customer customer);
        Task Delete(int id);
        Task SaveChangesAsync();
    }
}
