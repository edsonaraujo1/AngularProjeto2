using System.Threading.Tasks;
using Abp.Application.Services;
using AngularProjeto2.Sessions.Dto;

namespace AngularProjeto2.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
