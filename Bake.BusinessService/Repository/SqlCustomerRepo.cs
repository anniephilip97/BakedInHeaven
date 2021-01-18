using Bake.DataService;
using Bake.DataService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bake.BusinessService.Repository
{
    public class SqlCustomerRepo : ICustomerRepo
    {
        private readonly BakeDbContext _context;

        public SqlCustomerRepo(BakeDbContext context)
        {
            _context = context;
        }

        public void CreateCustomer(customer cust)
        {
            if(cust == null)
            {
                throw new ArgumentNullException(nameof(cust));
            }
            _context.customers.Add(cust);
        }

        public void DeleteCustomer(customer cust)
        {
            if (cust == null)
            {
                throw new ArgumentNullException(nameof(cust));
            }
            _context.customers.Remove(cust);
        }

        public IEnumerable<customer> GetAllCustomers()
        {
            return _context.customers.ToList();
        }

        public customer GetCustomerById(int id)
        {
            return _context.customers.FirstOrDefault(p => p.CustomerId == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges()>=0);
        }

        public void UpdateCustomer(customer cust)
        {
            //Nothing
        }
    }
}
