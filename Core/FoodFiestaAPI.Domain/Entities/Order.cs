using FoodFiestaAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFiestaAPI.Domain.Entities
{
    public class Order :BaseEntitiy
    {
        public Guid CustomerId { get; set; }
        public string Description { get; set; }

        public string Address { get; set; }

        [NotMapped]
        public ICollection<Product> Products { get; set; }

        public Customer Customer { get; set; }
    }
}
