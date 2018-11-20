using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABPCoreTest.EntityFrameworkCore
{
    public static class ABPCoreTestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPCoreTestDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABPCoreTestDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
