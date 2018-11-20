using System.Threading.Tasks;
using Abp.Application.Services;
using ABPCoreTest.Authorization.Accounts.Dto;

namespace ABPCoreTest.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
