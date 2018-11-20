using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPCoreTest.Authorization;

namespace ABPCoreTest
{
    [DependsOn(
        typeof(ABPCoreTestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPCoreTestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABPCoreTestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABPCoreTestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
