using OrderManagement.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagement.DAL.Repositories.Concrete
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _ctx;
        public CustomerRepository(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task Create(Customer customer)
        {
            await _ctx.Customers.AddAsync(customer);
        }

        public async Task Delete(int id)
        {
            Customer customer = await _ctx.Customers.FindAsync(id);
            if(customer != null)
            {
                _ctx.Customers.Remove(customer);
            }
        }

        public async Task<Customer> Get(int id)
        {
            return await _ctx.Customers.FindAsync(id);
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _ctx.Customers.AsQueryable();
        }

        public Customer Update(Customer customerChanges)
        {
            var customer = _ctx.Customers.Attach(customerChanges);
            customer.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _ctx.SaveChanges();
            return customerChanges;
        }

        public async Task SaveChangesAsync()
        {
            await _ctx.SaveChangesAsync();
        }
    }
}
