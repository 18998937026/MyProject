using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ABPCoreTest.Configuration.Dto;

namespace ABPCoreTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ABPCoreTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
