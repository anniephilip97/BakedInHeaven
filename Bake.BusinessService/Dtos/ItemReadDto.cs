using System;
using System.Collections.Generic;
using System.Text;

namespace Bake.BusinessService.Dtos
{
    public class ItemReadDto
    {
        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public string Quantity { get; set; }

        public string Price { get; set; }

        public int Kcal { get; set; }

        public string Veg { get; set; }

        public string Spl { get; set; }

        public int No_Available { get; set; }

        public string AvailableDate { get; set; }

    }
}
