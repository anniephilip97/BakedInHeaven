using System;
using System.Collections.Generic;
using System.Text;

namespace Bake.BusinessService.Dtos
{
    public class CustomerReadDto
    {
        public int CustomerId { get; set; }

        public string Name { get; set; }

        public string PhoneNo { get; set; }

        public string Address { get; set; }

        public string Zipcode { get; set; }

    }
}

