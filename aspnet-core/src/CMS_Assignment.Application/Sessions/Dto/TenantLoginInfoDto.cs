using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using CMS_Assignment.MultiTenancy;

namespace CMS_Assignment.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
