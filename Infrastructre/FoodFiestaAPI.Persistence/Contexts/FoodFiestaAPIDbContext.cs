using FoodFiestaAPI.Domain.Entities;
using FoodFiestaAPI.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodFiestaAPI.Persistence.Contexts
{
    public class FoodFiestaAPIDbContext : DbContext
    {
        public FoodFiestaAPIDbContext(DbContextOptions<FoodFiestaAPIDbContext> options) : base(options)
        { }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            //ChangeTracker : Entityler üzerinden yapılan değişiklikleri takip eder.

            var datas = ChangeTracker.Entries<BaseEntitiy>();

            foreach(var data in datas)
            {
                 _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedDate = DateTime.UtcNow,
                    _ => DateTime.UtcNow // EntityState.Deleted
                };
            }
                
            return await base.SaveChangesAsync(cancellationToken);
        }

    }
}
