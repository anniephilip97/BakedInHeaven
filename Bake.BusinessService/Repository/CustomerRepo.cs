using Bake.DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bake.BusinessService.Repository
{
    public class CustomerRepo : ICustomerRepo
    {
        public void CreateCustomer(customer cust)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(customer cust)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<customer> GetAllCustomers()
        {
            var customers = new List<customer>
            {
                new customer { CustomerId = 0, Name = "Anna", PhoneNo = "3654289715", Address = "SG Palaya", Zipcode = "520069" },
                new customer { CustomerId = 1, Name = "Tom", PhoneNo = "1598746322", Address = "TK Palaya", Zipcode = "520058" },
                new customer { CustomerId = 2, Name = "Tia", PhoneNo = "3654289715", Address = "JP Nagar", Zipcode = "520070" },
                new customer { CustomerId = 3, Name = "Jake", PhoneNo = "3654289715", Address = "Madivala", Zipcode = "520068" }
            };
            return customers;
        }

        public customer GetCustomerById(int id)
        {
            return new customer { CustomerId = 0, Name = "Anna", PhoneNo = "3654289715", Address = "SG Palaya", Zipcode = "520069" };

        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(customer cust)
        {
            throw new NotImplementedException();
        }
    }
}
