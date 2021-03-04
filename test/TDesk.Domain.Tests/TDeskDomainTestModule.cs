using TDesk.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TDesk
{
    [DependsOn(
        typeof(TDeskEntityFrameworkCoreTestModule)
        )]
    public class TDeskDomainTestModule : AbpModule
    {

    }
}