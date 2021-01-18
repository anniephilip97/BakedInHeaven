using System;
using System.Collections.Generic;
using Bake.DataService.Models;
using System.Text;

namespace Bake.BusinessService.Repository
{

    public interface ICustomerRepo
    {
        bool SaveChanges();
        IEnumerable<customer> GetAllCustomers();
        customer GetCustomerById(int id);

        void CreateCustomer(customer cust);
        void UpdateCustomer(customer cust);
        void DeleteCustomer(customer cust);
    }
}
