using Volo.Abp.Modularity;

namespace TDesk
{
    [DependsOn(
        typeof(TDeskApplicationModule),
        typeof(TDeskDomainTestModule)
        )]
    public class TDeskApplicationTestModule : AbpModule
    {

    }
}