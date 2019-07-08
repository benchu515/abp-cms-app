using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CMS_Assignment.MultiTenancy.Dto;

namespace CMS_Assignment.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

