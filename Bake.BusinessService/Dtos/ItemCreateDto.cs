using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bake.BusinessService.Dtos
{
    public class ItemCreateDto
    {
        [Required]
        [MaxLength(100)]
        public string ItemName { get; set; }

        [Required]
        [MaxLength(10)]
        public string Quantity { get; set; }

        [Required]
        [MaxLength(10)]
        public string Price { get; set; }

        [Required]
        public int Kcal { get; set; }

        [Required]
        [MaxLength(10)]
        public string Veg { get; set; }

        [Required]
        [MaxLength(15)]
        public string Spl { get; set; }

        [Required]
        public int No_Available { get; set; }

        [Required]
        [MaxLength(10)]
        public string AvailableDate { get; set; }

    }
}
