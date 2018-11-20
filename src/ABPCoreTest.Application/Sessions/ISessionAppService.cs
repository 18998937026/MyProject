using System.Threading.Tasks;
using Abp.Application.Services;
using ABPCoreTest.Sessions.Dto;

namespace ABPCoreTest.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
