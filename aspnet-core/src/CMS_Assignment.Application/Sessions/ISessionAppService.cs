using System.Threading.Tasks;
using Abp.Application.Services;
using CMS_Assignment.Sessions.Dto;

namespace CMS_Assignment.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
