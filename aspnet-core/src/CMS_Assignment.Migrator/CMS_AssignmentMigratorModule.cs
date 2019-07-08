using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CMS_Assignment.Configuration;
using CMS_Assignment.EntityFrameworkCore;
using CMS_Assignment.Migrator.DependencyInjection;

namespace CMS_Assignment.Migrator
{
    [DependsOn(typeof(CMS_AssignmentEntityFrameworkModule))]
    public class CMS_AssignmentMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public CMS_AssignmentMigratorModule(CMS_AssignmentEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(CMS_AssignmentMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                CMS_AssignmentConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(CMS_AssignmentMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
