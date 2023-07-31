using FoodFiestaAPI.Application.Repositories;
using FoodFiestaAPI.Domain.Entities;
using FoodFiestaAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoodFiestaAPI.Persistence.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(FoodFiestaAPIDbContext context) : base(context)
        {
        }
    }
}
