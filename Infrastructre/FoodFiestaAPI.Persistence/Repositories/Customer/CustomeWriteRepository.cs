using FoodFiestaAPI.Application.Repositories;
using FoodFiestaAPI.Domain.Entities;
using FoodFiestaAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFiestaAPI.Persistence.Repositories
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(FoodFiestaAPIDbContext context) : base(context)
        {
        }
    }
}
