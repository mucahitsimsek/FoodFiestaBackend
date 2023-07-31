using FoodFiestaAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFiestaAPI.Domain.Entities
{
    public class Product : BaseEntitiy
    {
        public string Name { get; set; }

        public int Stock { get; set; }

        public float Price { get; set; }

        [NotMapped]
        public ICollection<Order> Orders { get; set; }

    }
}
