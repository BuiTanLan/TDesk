using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TDesk.Data;
using Volo.Abp.DependencyInjection;

namespace TDesk.EntityFrameworkCore
{
    public class EntityFrameworkCoreTDeskDbSchemaMigrator
        : ITDeskDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreTDeskDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the TDeskMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<TDeskMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}