using TDesk.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace TDesk.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(TDeskEntityFrameworkCoreDbMigrationsModule),
        typeof(TDeskApplicationContractsModule)
        )]
    public class TDeskDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
