using FoodFiestaAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFiestaAPI.Domain.Entities
{
    public class Customer : BaseEntitiy
    {
        public string Name { get; set; }

        [NotMapped]
        public ICollection<Order> orders { get; set; }

    }
}
