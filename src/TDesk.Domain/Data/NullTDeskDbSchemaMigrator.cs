using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TDesk.Data
{
    /* This is used if database provider does't define
     * ITDeskDbSchemaMigrator implementation.
     */
    public class NullTDeskDbSchemaMigrator : ITDeskDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}