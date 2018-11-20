using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABPCoreTest.Authorization.Roles;
using ABPCoreTest.Authorization.Users;
using ABPCoreTest.MultiTenancy;

namespace ABPCoreTest.EntityFrameworkCore
{
    public class ABPCoreTestDbContext : AbpZeroDbContext<Tenant, Role, User, ABPCoreTestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ABPCoreTestDbContext(DbContextOptions<ABPCoreTestDbContext> options)
            : base(options)
        {
        }
    }
}
