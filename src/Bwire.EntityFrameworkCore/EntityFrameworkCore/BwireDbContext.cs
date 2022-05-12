using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Bwire.Authorization.Roles;
using Bwire.Authorization.Users;
using Bwire.MultiTenancy;

namespace Bwire.EntityFrameworkCore
{
    public class BwireDbContext : AbpZeroDbContext<Tenant, Role, User, BwireDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public BwireDbContext(DbContextOptions<BwireDbContext> options)
            : base(options)
        {
        }
    }
}
