using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ABPCoreTest.Controllers
{
    public abstract class ABPCoreTestControllerBase: AbpController
    {
        protected ABPCoreTestControllerBase()
        {
            LocalizationSourceName = ABPCoreTestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
