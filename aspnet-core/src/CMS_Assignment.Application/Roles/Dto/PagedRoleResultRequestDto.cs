using Abp.Application.Services.Dto;

namespace CMS_Assignment.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

