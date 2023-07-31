using FoodFiestaAPI.Application.Repositories;
using FoodFiestaAPI.Domain.Entities;
using FoodFiestaAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFiestaAPI.Persistence.Repositories
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(FoodFiestaAPIDbContext context) : base(context)
        {
        }
    }
}
