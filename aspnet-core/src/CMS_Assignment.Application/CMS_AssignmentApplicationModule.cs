using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CMS_Assignment.Authorization;

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
