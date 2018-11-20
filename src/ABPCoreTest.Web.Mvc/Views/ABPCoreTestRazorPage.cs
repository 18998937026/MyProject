using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace ABPCoreTest.Web.Views
{
    public abstract class ABPCoreTestRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected ABPCoreTestRazorPage()
        {
            LocalizationSourceName = ABPCoreTestConsts.LocalizationSourceName;
        }
    }
}
