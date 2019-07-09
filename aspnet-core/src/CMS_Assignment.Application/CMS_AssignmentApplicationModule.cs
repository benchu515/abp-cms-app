using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CMS_Assignment.Authorization;
using CMS_Assignment.Pages;
using CMS_Assignment.Pages.Dto;

namespace CMS_Assignment
{
    [DependsOn(
        typeof(CMS_AssignmentCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CMS_AssignmentApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CMS_AssignmentAuthorizationProvider>();
            Configuration.Modules.AbpAutoMapper().Configurators.Add(config =>
            {
                config.CreateMap<Page, PageDto>()
                .ForMember(p => p.pageName, options => options.MapFrom(input => input.Name))
                .ForMember(p => p.pageContent, options => options.MapFrom(input => input.Content));
            });
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CMS_AssignmentApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
