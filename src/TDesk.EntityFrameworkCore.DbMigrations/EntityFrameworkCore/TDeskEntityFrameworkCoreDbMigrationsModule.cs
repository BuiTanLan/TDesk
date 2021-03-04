using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace TDesk.EntityFrameworkCore
{
    [DependsOn(
        typeof(TDeskEntityFrameworkCoreModule)
        )]
    public class TDeskEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<TDeskMigrationsDbContext>();
        }
    }
}
