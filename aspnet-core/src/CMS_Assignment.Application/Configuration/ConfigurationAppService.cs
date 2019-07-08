using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using CMS_Assignment.Configuration.Dto;

namespace CMS_Assignment.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : CMS_AssignmentAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
