using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AngularProjeto2.Configuration.Dto;

namespace AngularProjeto2.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AngularProjeto2AppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
