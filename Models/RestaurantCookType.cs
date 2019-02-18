using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class RestaurantCookType
    {
        [Key]
        [Column(Order = 1)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 2)]
        public Restaurant RestaurantId { get; set; }

        [Key]
        [Column(Order = 3)]
        public CookType CookTypeId { get; set; }
    }
}
