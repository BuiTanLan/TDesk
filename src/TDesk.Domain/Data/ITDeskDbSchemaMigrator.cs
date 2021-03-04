using System.Threading.Tasks;

namespace TDesk.Data
{
    public interface ITDeskDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
