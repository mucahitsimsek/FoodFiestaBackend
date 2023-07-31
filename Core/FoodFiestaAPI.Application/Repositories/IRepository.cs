using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodFiestaAPI.Domain.Entities.Common;

namespace FoodFiestaAPI.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntitiy
    {
        DbSet<T> Table { get; }

    }
}
