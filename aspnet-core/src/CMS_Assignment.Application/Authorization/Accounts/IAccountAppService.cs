using System.Threading.Tasks;
using Abp.Application.Services;
using CMS_Assignment.Authorization.Accounts.Dto;

namespace CMS_Assignment.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
