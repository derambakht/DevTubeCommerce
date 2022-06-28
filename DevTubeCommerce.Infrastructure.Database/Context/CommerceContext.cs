using DevTubeCommerce.Domain.Core.Catalogs.Categories;
using DevTubeCommerce.Domain.Core.Catalogs.Features;
using DevTubeCommerce.Domain.Core.Catalogs.Products;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTubeCommerce.Infrastructure.Database.Context
{
    public class CommerceContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Product> Products { get; set; }

        public CommerceContext(DbContextOptions<CommerceContext> options):base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CommerceContext).Assembly);
        }
    }
}
