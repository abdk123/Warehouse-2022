using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Bwire.Authorization.Roles;
using Bwire.Authorization.Users;
using Bwire.MultiTenancy;
using Bwire.Inventory.Warehouses;
using Bwire.Inventory.Indexes;
using Bwire.Inventory.Suppliers;

namespace Bwire.EntityFrameworkCore
{
    public class BwireDbContext : AbpZeroDbContext<Tenant, Role, User, BwireDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BwireDbContext(DbContextOptions<BwireDbContext> options)
            : base(options)
        {
        }

        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
