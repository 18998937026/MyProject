using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPCoreTest.Configuration;

namespace ABPCoreTest.Web.Host.Startup
{
    [DependsOn(
       typeof(ABPCoreTestWebCoreModule))]
    public class ABPCoreTestWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABPCoreTestWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPCoreTestWebHostModule).GetAssembly());
        }
    }
}
