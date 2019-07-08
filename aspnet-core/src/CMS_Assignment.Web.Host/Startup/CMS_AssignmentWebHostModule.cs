using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CMS_Assignment.Configuration;

namespace CMS_Assignment.Web.Host.Startup
{
    [DependsOn(
       typeof(CMS_AssignmentWebCoreModule))]
    public class CMS_AssignmentWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public CMS_AssignmentWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CMS_AssignmentWebHostModule).GetAssembly());
        }
    }
}
