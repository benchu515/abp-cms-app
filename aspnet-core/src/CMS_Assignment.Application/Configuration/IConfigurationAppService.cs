using System.Threading.Tasks;
using CMS_Assignment.Configuration.Dto;

namespace CMS_Assignment.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
