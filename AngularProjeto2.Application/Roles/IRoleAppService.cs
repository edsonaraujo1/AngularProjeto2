using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AngularProjeto2.Roles.Dto;

namespace AngularProjeto2.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
