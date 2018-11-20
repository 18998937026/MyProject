using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABPCoreTest.Configuration;
using ABPCoreTest.Web;

namespace ABPCoreTest.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABPCoreTestDbContextFactory : IDesignTimeDbContextFactory<ABPCoreTestDbContext>
    {
        public ABPCoreTestDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPCoreTestDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABPCoreTestDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABPCoreTestConsts.ConnectionStringName));

            return new ABPCoreTestDbContext(builder.Options);
        }
    }
}
