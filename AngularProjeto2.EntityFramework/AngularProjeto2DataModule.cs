using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using AngularProjeto2.EntityFramework;

namespace AngularProjeto2
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(AngularProjeto2CoreModule))]
    public class AngularProjeto2DataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<AngularProjeto2DbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
