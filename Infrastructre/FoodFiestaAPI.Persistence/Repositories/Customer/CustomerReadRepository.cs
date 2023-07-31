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
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(FoodFiestaAPIDbContext context) : base(context)
        {
        }
    }
}
