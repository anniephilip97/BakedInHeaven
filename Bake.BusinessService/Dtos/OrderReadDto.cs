using Bake.DataService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bake.BusinessService.Dtos
{
    public class OrderReadDto
    {
        public int OrderId { get; set; }

        public int CustomerId { get; set; }
        public customer customer { get; set; }

        public int ItemId { get; set; }
        public item item { get; set; }

        public int TotalNo { get; set; }

        public string Price { get; set; }

        public string DateOfDelivery { get; set; }

        public string Status { get; set; }

    }
}

