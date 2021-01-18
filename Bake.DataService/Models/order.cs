using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Bake.DataService.Models
{
    public class order
    {
        [Key]
        public int OrderId { get; set; }

        [Required]
        public int CustomerId { get; set; }
        public customer customer { get; set; }

        [Required]
        public int ItemId { get; set; }
        public item item { get; set; }

        [Required]
        public int TotalNo { get; set; }

        [Required]
        [MaxLength(10)]
        public string Price { get; set; }

        [Required]
        [MaxLength(20)]
        public string DateOfDelivery { get; set; }

        [Required]
        [MaxLength(15)]
        public string Status { get; set; }

    }
}
