using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using CMS_Assignment.Roles.Dto;
using CMS_Assignment.Users.Dto;

namespace CMS_Assignment.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
