using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using AngularProjeto2.EntityFramework;

namespace AngularProjeto2.Migrator
{
    [DependsOn(typeof(AngularProjeto2DataModule))]
    public class AngularProjeto2MigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<AngularProjeto2DbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}