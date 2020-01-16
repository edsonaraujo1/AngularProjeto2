using System.Threading.Tasks;
using Abp.Application.Services;
using AngularProjeto2.Configuration.Dto;

namespace AngularProjeto2.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}