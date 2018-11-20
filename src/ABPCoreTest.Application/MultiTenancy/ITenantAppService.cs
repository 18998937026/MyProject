using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABPCoreTest.MultiTenancy.Dto;

namespace ABPCoreTest.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
