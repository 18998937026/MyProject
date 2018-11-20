using Abp.AspNetCore.Mvc.ViewComponents;

namespace ABPCoreTest.Web.Views
{
    public abstract class ABPCoreTestViewComponent : AbpViewComponent
    {
        protected ABPCoreTestViewComponent()
        {
            LocalizationSourceName = ABPCoreTestConsts.LocalizationSourceName;
        }
    }
}
