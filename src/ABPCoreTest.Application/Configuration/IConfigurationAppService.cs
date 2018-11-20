using System.Threading.Tasks;
using ABPCoreTest.Configuration.Dto;

namespace ABPCoreTest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
