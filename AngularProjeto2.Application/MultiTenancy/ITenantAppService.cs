using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AngularProjeto2.MultiTenancy.Dto;

namespace AngularProjeto2.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
